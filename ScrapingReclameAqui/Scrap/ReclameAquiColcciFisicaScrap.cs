using ScrapingReclameAqui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapingReclameAqui.Scrap
{
    class ReclameAquiColcciFisicaScrap : ReclameAquiScrapBase
    {
        public override void ConfigureCompany()
        {
            base.urlListaReclamacoes = $"{base.baseUrl}/empresa/colcci-loja-fisica/lista-reclamacoes/";
            base.company = CompanyEnum.Colcci;
            base.type = TypeEnum.Fisica;
        }
    }
}
