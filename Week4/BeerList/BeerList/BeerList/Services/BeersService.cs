using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BeerList.Models;
using Newtonsoft.Json;

namespace BeerList.Services
{
    public class BeersService : IBeersService
    {
        public async Task<IEnumerable<Beers>> GetAllBeersAsync()
        {
            var beers = new List<Beers>();
            try
            {
                using (var client = new HttpClient())
                {
                    var stringResponse = await client.GetStringAsync("https://api.punkapi.com/v2/beers");
                    beers = JsonConvert.DeserializeObject<List<Beers>>(stringResponse);
                }

               
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Exception: {ex}");
            }

            return beers;

        }
        
    }
}
