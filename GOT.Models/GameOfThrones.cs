using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOT.Models
{
    public class GameOfThrones
    {        
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("house")]
        public string House { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("birth")]
        public int? Birth { get; set; }
    }
}
