using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerList.Models
{
    public class Ingredients
    {
        [JsonProperty("malt")]
        public Malt[] Malt { get; set; }

        [JsonProperty("hops")]
        public Hop[] Hops { get; set; }

        [JsonProperty("yeast")]
        public string Yeast { get; set; }
    }
}
