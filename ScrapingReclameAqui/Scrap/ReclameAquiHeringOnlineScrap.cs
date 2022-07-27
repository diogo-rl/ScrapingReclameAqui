using ScrapingReclameAqui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapingReclameAqui.Scrap
{
    class ReclameAquiHeringOnlineScrap : ReclameAquiScrapBase
    {
        public override void ConfigureCompany()
        {
            base.urlListaReclamacoes = $"{base.baseUrl}/empresa/hering-loja-virtual/lista-reclamacoes/";
            base.company = CompanyEnum.Hering;
            base.type = TypeEnum.Online;
        }
    }
}
