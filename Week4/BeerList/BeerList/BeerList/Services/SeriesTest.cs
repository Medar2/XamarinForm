using BeerList.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BeerList.Services
{
    public class SeriesTest : ISeriesService
    {
        public Task<IEnumerable<Serie>> GetAllSeriesAsync()
        {
            return null;
        }
    }
}
