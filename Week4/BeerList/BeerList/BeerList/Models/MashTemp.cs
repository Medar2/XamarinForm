using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerList.Models
{
    public partial class MashTemp
    {
        [JsonProperty("temp")]
        public BoilVolume Temp { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }
    }
}
