using ScrapingReclameAqui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapingReclameAqui.Scrap
{
    class ReclameAquiRennerScrap : ReclameAquiScrapBase
    {
        public override void ConfigureCompany()
        {
            base.urlListaReclamacoes = $"{base.baseUrl}/empresa/lojas-renner/lista-reclamacoes/";
            base.company = CompanyEnum.Renner;
            base.type = TypeEnum.Fisica_Online;
        }
    }
}

