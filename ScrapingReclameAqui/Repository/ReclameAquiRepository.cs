using ScrapingReclameAqui.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ScrapingReclameAqui
{
    class ReclameAquiRepository
    {
        private readonly FirebaseHelper firebase = new FirebaseHelper();
        private Dictionary<string, Complaint> listServer = new Dictionary<string, Complaint>();

        public ReclameAquiRepository() 
        {
            listServer = GetList();
        }
        public void Save(List<Complaint> list)
        {

            int count = 0;
            NotifyHelper.Notify("Iniciando salvar...");
            if (list != null)
                foreach (Complaint c in list)
                {
                    count++;

                    if (count % 100 == 0)
                        NotifyHelper.Notify(count + " Mensagens Salvas");

                    if (!VerifyIfExists(c))
                        firebase.Save($"complaint/{c.Id}", c);
                    
                }
            NotifyHelper.Notify("Finalizado salvar.");
        }

        private bool VerifyIfExists(Complaint c)
        {
            if (listServer == null)
            {
                var result = firebase.Get($"complaint/{c.Id}");
                Complaint cpl = result.ResultAs<Complaint>();
                return (cpl != null);
            }
            else            
                return (listServer.ContainsKey(c.Id));
        }

        public Complaint Get(string id)
        {
            var result = firebase.Get($"complaint/{id}");
            Complaint cpl = result.ResultAs<Complaint>();
            return cpl;
        }

        public Dictionary<string, Complaint> GetList()
        {
            var result = firebase.Get($"complaint");
            Dictionary<string, Complaint> cpls = result.ResultAs<Dictionary<string, Complaint>>();
            return cpls;
        }        
    }
}
