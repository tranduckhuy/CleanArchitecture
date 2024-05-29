namespace PackIT.Infrastructure.EFCore.Models
{
    public class LocalizationReadModel
    {
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

        public static LocalizationReadModel Create(string value)
        {
            var splitLocalization = value.Split(',');
            return new LocalizationReadModel
            {
                City = splitLocalization.First(),
                Country = splitLocalization.Last()
            };
        }

        public override string ToString()
            => $"{City},{Country}";
    }
}
