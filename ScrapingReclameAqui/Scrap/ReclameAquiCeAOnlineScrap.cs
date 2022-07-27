using ScrapingReclameAqui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapingReclameAqui.Scrap
{
    class ReclameAquiCeAOnlineScrap : ReclameAquiScrapBase
    {
        public override void ConfigureCompany()
        {
            base.urlListaReclamacoes = $"{base.baseUrl}/empresa/cea-loja-online/lista-reclamacoes/";
            base.company = CompanyEnum.CEA;
            base.type = TypeEnum.Online;
        }
    }
}
