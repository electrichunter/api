 
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Server.Models;


namespace api.Server.Servisler
{
    public interface ISliderService
    {
        Task<int> GetSliderCountAsync();
        Task<List<SliderInfo>> GetSlidersAsync();
        Task SaveFilePathAsync(string filePath);

    }
}
