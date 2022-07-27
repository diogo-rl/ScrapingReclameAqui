using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ScrapingReclameAqui.Helper;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Collections.Concurrent;
using ScrapySharp.Network;
using ScrapingReclameAqui.Model;

namespace ScrapingReclameAqui
{
    class ReclameAquiScrapBase
    {
        public readonly string baseUrl = "https://www.reclameaqui.com.br";
        public string urlListaReclamacoes = "";
        public CompanyEnum company;
        public TypeEnum type;
        public ReclameAquiScrapBase() 
        {
            ConfigureCompany();
        }
        public virtual void ConfigureCompany() 
        {
            urlListaReclamacoes = $"https://www.reclameaqui.com.br/empresa/none/lista-reclamacoes/";
            this.company = CompanyEnum.None;
            this.type = TypeEnum.None;
        }
        private string GetValueFromTag(HtmlDocument doc, string divClass, string tag, string attribute)
        {
            IEnumerable<HtmlNode> list = null;
            try
            {
                list = doc.DocumentNode.SelectNodes($"//div[@class='{divClass}']").Descendants(tag);
            }
            catch { }
            if (list == null || list.Count() == 0)
                return "";
            if (!string.IsNullOrWhiteSpace(attribute))
                return list.FirstOrDefault().Attributes[attribute].Value;
            else
                return list.FirstOrDefault().InnerText;
        }

        public HtmlDocument GetData(string url) 
        {
            WebClientExtended client = new WebClientExtended();
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(System.Text.Encoding.UTF8.GetString(client.DownloadData(url)));
            return doc;
        }

        internal void StartScraping()
        {
            var rep = new ReclameAquiRepository();
            rep.Save(GetComplains());
        }

        private List<Complaint> GetComplains()
        {
            List<Complaint> complains = new List<Complaint>();
            List<string> urlsComments = GetListUrlsComments();
            NotifyHelper.Notify("Início obtendo as reclamações");
            int count = 0;
            int countError = 0;

            foreach (string url in urlsComments)
            {
                count++;
                
                if (count % 100 == 0)
                    NotifyHelper.Notify(count + " reclamações obtidas");
                try
                {
                    HtmlDocument doc = GetData(url);
                    string titulo = GetValueFromTag(doc, "lzlu7c-19 hpNFPP", "h1", null);
                    string situacao = GetValueFromTag(doc, "lzlu7c-18 ecigry", "span", null);
                    string dataCriacao = GetValueFromTag(doc, "lzlu7c-6 lzlu7c-8 dLWUvV ePqLRr", "span", null);
                    string reclamacao = GetValueFromTag(doc, "lzlu7c-19 hpNFPP", "p", null);

                    complains.Add(new Complaint()
                    {
                        Id = GetHash(url),
                        Title = titulo,
                        Status = situacao,
                        CreationDate = dataCriacao,
                        Text = reclamacao,
                        Company = company.ToString(),
                        Type = type.ToString(),
                        Url = url
                    });
                }
                catch { countError++; }
            }
            if(countError > 0)
                NotifyHelper.Notify(countError + " Erros nas reclamações obtidas");
            return complains;
        }

        private string GetHash(string url)
        {
            return MD5Helper.Generate(url);
        }

        private List<string> GetListUrlsComments()
        {
            NotifyHelper.Notify("Obtendo URLs das reclamacões");
            List<string> urlsComments = new List<string>();
            int pages = GetQtPages();
            for (int i = 1; i <= pages; i+=10)
            {
                if (i % 1000 == 0)
                    NotifyHelper.Notify(i + " URLs obtidas");

                try
                {
                    HtmlDocument doc = GetData(urlListaReclamacoes + $"?pagina={i}");

                    string erro = GetValueFromTag(doc, "sc-1p4i0ux-3 gszauH", "span", null);
                    if (!string.IsNullOrWhiteSpace(erro) && erro.Contains("Ops, algo deu errado"))
                        break;

                    var list = doc.DocumentNode.SelectNodes("//div[@class='sc-1pe7b5t-0 bJdtis']").Descendants("a");
                    foreach (var s in list)
                    {
                        string href = s.Attributes["href"].Value.Trim();
                        if (!string.IsNullOrWhiteSpace(href))
                            urlsComments.Add(baseUrl + href + (href.EndsWith("/") ? "" : "/"));
                    }
                }
                catch {  }
            }
            return urlsComments;
        }

        private int GetQtPages()
        {   
            HtmlDocument doc = GetData(urlListaReclamacoes);
            IEnumerable<HtmlNode> list = doc.DocumentNode.SelectNodes("//div[@class='sc-1sm4sxr-3 eejODo']").Descendants("li");
            int count = 0;
            int lastPage = 1;
            foreach (var s in list)
            {
                if (list.Count() - 2 == count)
                {
                    try
                    {
                        lastPage = Convert.ToInt32(s.InnerText.Trim());
                    }
                    catch { }
                }
                count++;
            }
            if (lastPage > 500)
                return 500 * 10;
            return lastPage * 10;
        }
    }
}
