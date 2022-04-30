using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HardCodeBrawlStarsAI.PlayerRecognation
{
    internal class ReadJson
    {
        public string PlayerName()
        {
            // This creates a new object of StreamReader, so we can READ THE .JSON Passwords.json which is hidden on Github
            StreamReader r = new StreamReader("jsconfig1.json"); // I HAVE ADDED A JSON FILE TO THE BIN FILE WITH THE USERNAME
            string JsonString = r.ReadToEnd();

            // This will then Deserialize the JSON that is saved as "string jsonString" above, then it will Parse the JSON
            ReadJson m = JsonConvert.DeserializeObject<ReadJson>(JsonString);
            dynamic Read = JObject.Parse(JsonString);

            // This will then save the JSON TOKEN and only gives it's object within'
            string PlayerNameString = Read.PlayerName;

            // Return the String
            return PlayerNameString;
        }
    }
}
