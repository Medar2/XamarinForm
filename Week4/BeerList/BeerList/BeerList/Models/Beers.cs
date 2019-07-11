using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerList.Models
{
    public class Beers
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("first_brewed")]
        public string FirstBrewed { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image_url")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("abv")]
        public double Abv { get; set; }

        [JsonProperty("ibu")]
        public long Ibu { get; set; }

        [JsonProperty("target_fg")]
        public long TargetFg { get; set; }

        [JsonProperty("target_og")]
        public long TargetOg { get; set; }

        [JsonProperty("ebc")]
        public long Ebc { get; set; }

        [JsonProperty("srm")]
        public long Srm { get; set; }

        [JsonProperty("ph")]
        public double Ph { get; set; }

        [JsonProperty("attenuation_level")]
        public long AttenuationLevel { get; set; }

        [JsonProperty("volume")]
        public BoilVolume Volume { get; set; }

        [JsonProperty("boil_volume")]
        public BoilVolume BoilVolume { get; set; }

        [JsonProperty("method")]
        public Method Method { get; set; }

        [JsonProperty("ingredients")]
        public Ingredients Ingredients { get; set; }

        [JsonProperty("food_pairing")]
        public string[] FoodPairing { get; set; }

        [JsonProperty("brewers_tips")]
        public string BrewersTips { get; set; }

        [JsonProperty("contributed_by")]
        public string ContributedBy { get; set; }
    }
}
