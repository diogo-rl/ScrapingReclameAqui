using ScrapingReclameAqui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapingReclameAqui.Scrap
{
    class ReclameAquiBeagleScrap : ReclameAquiScrapBase
    {
        public override void ConfigureCompany()
        {
            base.urlListaReclamacoes = $"{base.baseUrl}/empresa/beagle/lista-reclamacoes/";
            base.company = CompanyEnum.Beagle;
            base.type = TypeEnum.Fisica_Online;
        }
    }
}
