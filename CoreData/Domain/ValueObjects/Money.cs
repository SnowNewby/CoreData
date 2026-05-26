using CoreData.DTO.Domain.Enums;

namespace CoreData.DTO.Domain.ValueObjects;

public class Money
{
    private decimal Value {get;}
    private Currency Currency {get;}
    
    private const string ExceptionValueMoneyNegative = "Value cannot be negative";
    private const string ExceptionCurrencyNull = "Currency cannot be null or cannot be EUR/USD/RUB";

    public Money(decimal value, Currency currency)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value), value, ExceptionValueMoneyNegative);

        if (currency == null || currency == Currency.EUR || currency == Currency.USD || currency == Currency.RUB)
            throw new ArgumentException(ExceptionCurrencyNull);
        
        Value = value;
        Currency = currency;
    }

    public override string ToString()
    {
        return $"{Value}{Currency}";
    }
}