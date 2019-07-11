using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerList.Models
{
    public class Hop
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public BoilVolume Amount { get; set; }

        [JsonProperty("add")]
        public string Add { get; set; }

        [JsonProperty("attribute")]
        public string Attribute { get; set; }
    }
}
