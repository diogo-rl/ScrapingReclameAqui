using ScrapingReclameAqui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapingReclameAqui.Scrap
{
    class ReclameAquiLacosteScrap : ReclameAquiScrapBase
    {
        public override void ConfigureCompany()
        {
            base.urlListaReclamacoes = $"{base.baseUrl}/empresa/lacoste-brasil/lista-reclamacoes/";
            base.company = CompanyEnum.Lacoste;
            base.type = TypeEnum.Fisica_Online;
        }
    }
}