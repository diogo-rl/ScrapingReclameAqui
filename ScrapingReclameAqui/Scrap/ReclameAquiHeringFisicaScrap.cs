using ScrapingReclameAqui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapingReclameAqui.Scrap
{
    class ReclameAquiHeringFisicaScrap : ReclameAquiScrapBase
    {
        public override void ConfigureCompany()
        {
            base.urlListaReclamacoes = $"{base.baseUrl}/empresa/hering-lojas-fisicas/lista-reclamacoes/";
            base.company = CompanyEnum.Hering;
            base.type = TypeEnum.Fisica;
        }
    }
}
