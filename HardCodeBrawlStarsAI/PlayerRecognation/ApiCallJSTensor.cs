using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace HardCodeBrawlStarsAI.PlayerRecognation
{
    internal class ApiCallJSTensor
    {
        /// <summary>
        /// This is a class to call an API that will return the TensorFlow models data back to me
        /// </summary>
        
        public string GetData()
        {
            // Url (Local host so Only I can access it hehe)
            var url = "http://localhost:3000";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);


            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result;
            }
        }
    }
}
