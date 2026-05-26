namespace CoreData.DTO.Domain.ValueObjects;

public class Address
{
    private string City {get;}
    private string Street {get;}
    private string HouseNumber {get;}

    private const string ExceptionAddressNullable = $"Value cannot be null";
    
    public Address (string city, string street, string houseNumber)
    {
        if (string.IsNullOrWhiteSpace(city))
            throw new ArgumentException(ExceptionAddressNullable, nameof(city));
        
        if (string.IsNullOrWhiteSpace(street))
            throw new ArgumentException(ExceptionAddressNullable, nameof(street));
        
        if (string.IsNullOrWhiteSpace(houseNumber))
            throw new ArgumentException(ExceptionAddressNullable, nameof(houseNumber));
        
        City = city.Trim();
        Street = street.Trim();
        HouseNumber = houseNumber.Trim();
    }

    public override string ToString()
    {
        return $"Address: {City},{Street},{HouseNumber}";
    }
}