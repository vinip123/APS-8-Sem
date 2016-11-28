using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Xml.Linq;

namespace Denuncias.API
{
    public class ApiMaps
    {
        public static dynamic Getlat(string endereco, string cidade, string estado)
        {
            #region Chave da API
            string chave = "AIzaSyCwoj_TjZPBc7vMNmt-VzXKtMOqDST7O0k";
            #endregion

            using (var client = new HttpClient())
            {
                string url = string.Format("https://maps.googleapis.com/maps/api/geocode/json?address=" + endereco.Replace(" ", "+") + "+" + cidade + "+" + estado + "&key=" + chave);
                var json = client.GetStringAsync(url);
                var root = JsonConvert.DeserializeObject<Model.Geocoding.RootObject>(json.Result);

                return root;             
            }
        }
        
    }
}
