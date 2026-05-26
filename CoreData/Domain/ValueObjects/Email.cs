namespace CoreData.DTO.Domain.ValueObjects;

public class Email
{
    public string Value { get; }

    private const string ExceptionEmailValueNullable = "Email value cannot be null or empty";
    private const string ExceptionEmailIncorrect = "Email must contain @";
    private const string ExceptionEmailMaxLenght = "Email length is too long";
    private const string ExceptionEmailMinLenght = "Email minimum length is too short";

    private const int MaxLenghtEmail = 256;
    private const int MinLenghtEmail = 3;


    public Email(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException(ExceptionEmailValueNullable);

        if (!value.Contains("@"))
            throw new ArgumentException(ExceptionEmailIncorrect);

        if (value.Length > MaxLenghtEmail)
            throw new ArgumentException(ExceptionEmailMaxLenght);

        if (value.Length < MinLenghtEmail)
            throw new ArgumentException(ExceptionEmailMinLenght);

        Value = value.ToLowerInvariant().Trim();
    }

    ///TODO: парсинг на пользовательский адресс и домен.
    
    public override string ToString()
    {
        return Value;
    }
}