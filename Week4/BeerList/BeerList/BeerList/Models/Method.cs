using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerList.Models
{
    public class Method
    {
        [JsonProperty("mash_temp")]
        public MashTemp[] MashTemp { get; set; }

        [JsonProperty("fermentation")]
        public Fermentation Fermentation { get; set; }

        [JsonProperty("twist")]
        public object Twist { get; set; }
    }
}
