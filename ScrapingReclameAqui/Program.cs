using HtmlAgilityPack;
using ScrapingReclameAqui.Model;
using ScrapingReclameAqui.Scrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapingReclameAqui
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StartCeAOnline();
            StartHeringOnline();
            StartHeringFisica();
            StartMarisaOnline();
            StartMarisaFisica();
            StartRennerFisica();
            StartBeagleFisicaOnline();
            StartColcciOnline();
            StartColcciFisica();
            StartDudalinaFisicaOnline();
            StartLacosteFisicaOnline();
            StartTommyFisicaOnline();
            Console.ReadKey();
        }

        private static void StartMarisaOnline()
        {
            Console.WriteLine("Iniciando Marisa Online");
            new ReclameAquiMarisaOnlineScrap().StartScraping();
            Console.WriteLine($"************Finalizado {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}***********");
        }

        private static void StartMarisaFisica()
        {
            Console.WriteLine("Iniciando Marisa Fisica");
            new ReclameAquiMarisaFisicaScrap().StartScraping();
            Console.WriteLine($"************Finalizado {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}***********");
        }

        private static void StartHeringOnline()
        {
            Console.WriteLine("Iniciando Hering Online");
            new ReclameAquiHeringOnlineScrap().StartScraping();
            Console.WriteLine($"************Finalizado {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}***********");
        }

        private static void StartHeringFisica()
        {
            Console.WriteLine("Iniciando Hering Fisica");
            new ReclameAquiHeringFisicaScrap().StartScraping();
            Console.WriteLine($"************Finalizado {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}***********");
        }

        private static void StartCeAOnline()
        {
            Console.WriteLine("Iniciando C&A Online");
            new ReclameAquiCeAOnlineScrap().StartScraping();
            Console.WriteLine($"************Finalizado {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}***********");
        }

        private static void StartRennerFisica()
        {
            Console.WriteLine("Iniciando Renner Fisica");
            new ReclameAquiRennerScrap().StartScraping();
            Console.WriteLine($"************Finalizado {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}***********");
        }

        private static void StartBeagleFisicaOnline()
        {
            Console.WriteLine("Iniciando Beagle Fisica Online");
            new ReclameAquiBeagleScrap().StartScraping();
            Console.WriteLine($"************Finalizado {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}***********");
        }

        private static void StartColcciOnline()
        {
            Console.WriteLine("Iniciando Colcci Online");
            new ReclameAquiColcciOnlineScrap().StartScraping();
            Console.WriteLine($"************Finalizado {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}***********");
        }

        private static void StartColcciFisica()
        {
            Console.WriteLine("Iniciando Colcci Fisica");
            new ReclameAquiColcciFisicaScrap().StartScraping();
            Console.WriteLine($"************Finalizado {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}***********");
        }

        private static void StartDudalinaFisicaOnline()
        {
            Console.WriteLine("Iniciando Dudalina Fisica Online");
            new ReclameAquiDudalinaScrap().StartScraping();
            Console.WriteLine($"************Finalizado {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}***********");
        }

        private static void StartLacosteFisicaOnline()
        {
            Console.WriteLine("Iniciando Lacoste Fisica Online");
            new ReclameAquiLacosteScrap().StartScraping();
            Console.WriteLine($"************Finalizado {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}***********");
        }

        private static void StartTommyFisicaOnline()
        {
            Console.WriteLine("Iniciando Tommy Fisica Online");
            new ReclameAquiTommyScrap().StartScraping();
            Console.WriteLine($"************Finalizado {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}***********");
        }

    }
}
