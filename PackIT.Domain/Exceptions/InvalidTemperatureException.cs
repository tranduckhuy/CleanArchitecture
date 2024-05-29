using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
    public class InvalidTemperatureException : PackITException
    {
        public double Temperature { get; }
        public InvalidTemperatureException(double temperature) : base($"Value '{temperature}' is invalid temperature!")
            => Temperature = temperature;
    }
}
