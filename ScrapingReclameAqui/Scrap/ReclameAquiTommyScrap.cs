using ScrapingReclameAqui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapingReclameAqui.Scrap
{
    class ReclameAquiTommyScrap : ReclameAquiScrapBase
    {
        public override void ConfigureCompany()
        {
            base.urlListaReclamacoes = $"{base.baseUrl}/empresa/tommy-hilfiger-brasil-vestuario/lista-reclamacoes/";
            base.company = CompanyEnum.Tommy;
            base.type = TypeEnum.Fisica_Online;
        }
    }
}
