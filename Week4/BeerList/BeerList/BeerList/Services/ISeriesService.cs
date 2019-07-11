using BeerList.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BeerList.Services
{
    public interface ISeriesService
    {
        Task<IEnumerable<Serie>> GetAllSeriesAsync();
    }
}
