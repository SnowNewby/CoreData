namespace CoreData.DTO.Domain.ValueObjects;

public class PhoneNumber
{
    public string Value { get; }
    public string CountryCode { get; }

    private const string ExceptionPhoneNumberNullable = "Value cannot be null or whitespace.";
    private const string ExceptionCountryCodeNullable = "Country code cannot be null or whitespace.";
    private const string ExceptionNumberFormat = "Value cannot be correct country code";
    
    public PhoneNumber(string value, string countryCode)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException(ExceptionPhoneNumberNullable, nameof(value));
        
        if (string.IsNullOrWhiteSpace(countryCode))
            throw new ArgumentException(ExceptionCountryCodeNullable, nameof(countryCode));
        
        if (!countryCode.Contains('+'))
            throw new ArgumentException(ExceptionNumberFormat, nameof(countryCode));
        
        Value = value.Trim();
        CountryCode = countryCode.Trim();
    }

    public string FormatPhoneNumber()
    {
        return $"{CountryCode}{Value}";
    }
    
}