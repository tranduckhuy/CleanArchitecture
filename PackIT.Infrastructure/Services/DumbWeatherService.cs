using PackIT.Application.DTO.Externals;
using PackIT.Application.Services;
using PackIT.Domain.ValueObjects;

namespace PackIT.Infrastructure.Services
{
    internal sealed class DumbWeatherService : IWeatherSerivce
    {
        public Task<WeatherDTO> GetWeatherAsync(Localization localization)
            => Task.FromResult(new WeatherDTO(new Random().Next(5, 30)));
    }
}
