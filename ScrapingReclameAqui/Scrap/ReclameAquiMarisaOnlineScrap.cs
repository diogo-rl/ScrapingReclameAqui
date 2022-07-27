using ScrapingReclameAqui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapingReclameAqui.Scrap
{
    class ReclameAquiMarisaOnlineScrap : ReclameAquiScrapBase
    {
        public override void ConfigureCompany()
        {
            base.urlListaReclamacoes = $"{base.baseUrl}/empresa/lojas-marisa-loja-online/lista-reclamacoes/";
            base.company = CompanyEnum.Marisa;
            base.type = TypeEnum.Online;
        }
    }
}


