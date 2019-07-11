using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerList.Models
{
    public partial class Fermentation
    {
        [JsonProperty("temp")]
        public BoilVolume Temp { get; set; }
    }

}
