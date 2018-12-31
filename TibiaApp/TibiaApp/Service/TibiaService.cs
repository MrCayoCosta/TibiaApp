using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using TibiaApp.Model;

namespace TibiaApp.Service
{
    public class TibiaService
    {
        private static string url = "https://api.tibiadata.com/v2/characters/{0}.json";

        public TibiaService()
        {
                
        }

        public static Example buscaChar(string name)
        {
            string parametro = string.Format(url, name);

            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(parametro);
 
             Example chr = JsonConvert.DeserializeObject<Example>(conteudo);

            if (chr == null) return null;
            return chr;

        }
    }
}
