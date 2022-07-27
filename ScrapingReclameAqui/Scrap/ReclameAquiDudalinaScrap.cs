using ScrapingReclameAqui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapingReclameAqui.Scrap
{
    class ReclameAquiDudalinaScrap : ReclameAquiScrapBase
    {
        public override void ConfigureCompany()
        {
            base.urlListaReclamacoes = $"{base.baseUrl}/empresa/dudalina/lista-reclamacoes/";
            base.company = CompanyEnum.Dudalina;
            base.type = TypeEnum.Fisica_Online;
        }
    }
}
