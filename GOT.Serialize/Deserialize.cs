using GOT.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GOT.Serialize
{
    public class Deserialize
    {
        public GameOfThrones[] Start()
        {
            WebClient client = new WebClient();
            string json = client.DownloadString("https://api.got.show//api/book/characters");
            var result = JsonConvert.DeserializeObject<GameOfThrones[]>(json);

            return result;
        }
    }
}
