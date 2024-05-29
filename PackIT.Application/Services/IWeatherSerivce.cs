using PackIT.Application.DTO.Externals;
using PackIT.Domain.ValueObjects;

namespace PackIT.Application.Services
{
    public interface IWeatherSerivce
    {
        Task<WeatherDTO> GetWeatherAsync(Localization localization);
    }
}
