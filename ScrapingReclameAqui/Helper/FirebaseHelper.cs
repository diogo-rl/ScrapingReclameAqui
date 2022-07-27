using System;
using System.Collections.Generic;
using System.Text;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace ScrapingReclameAqui
{
    class FirebaseHelper
    {
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "",
            BasePath = ""
        };

        IFirebaseClient client;

        internal FirebaseResponse Get(string path)
        {
            return client.Get(path);
        }

        internal void Update<T>(string path, T obj)
        {
            client.Update(path, obj);
        }

        public FirebaseHelper()
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                throw new Exception("there was problem in the internet.");
            }
        }

        internal List<Complaint> GetList(string path)
        {
            //List<Complaint> list = client.Get(path);
            //return list;
            return new List<Complaint>();
        }

        internal async void Save<T>(string path, T obj)
        {
           await client.SetAsync(path, obj);
        }
    }
}
