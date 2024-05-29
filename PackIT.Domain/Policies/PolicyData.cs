using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies
{
    public record PolicyData(TravelDays Days, ValueObjects.Temperature Temperature, 
        Localization Localization, Constant.Gender Gender)
    {
    }
}
