using CoreData.DTO.Domain.ValueObjects;

namespace CoreData.DTO.Domain.models;

public class User
{
    public string Id { get; private set; }
    public string Username {get; private set;}
    public string FirstName {get; private set;}
    public string LastName {get; private set;}
    public string Gender {get; private set;}
    public string JobTitle {get; private set;}
    
    public Email Email {get; private set;}
    public PhoneNumber PhoneNumber {get; private set;}
    public Money Salary {get; private set;}
    public Address Address {get; private set;}

    private const string ExceptionFieldNullable = "cannot be null";
    
    private User() { }

    public User (string id , string username, string firstName, string lastName, string gender, string jobTitle)
    {
        Id = id;
        Username = username;
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        JobTitle = jobTitle;
    }

    public User(string id, string username, string firstName, string lastName, string gender, Email email)
    {
        Id = id;
        Username = username;
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Email = email;
    }
    
    public User(string id, string username, string firstName, string lastName, string gender, 
        Email email,  PhoneNumber phone)
    {
        Id = id;
        Username = username;
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Email = email;
        PhoneNumber = phone;
    }
    
    public User(string id, string username, string firstName, string lastName, string gender, 
        Email email, PhoneNumber phone, Money salary)
    {
        Id = id;
        Username = username;
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Email = email;
        PhoneNumber = phone;
        Salary = salary;
    }

    public void UpdateAddress(Address address)
    {
        Address = address ?? throw new ArgumentNullException(nameof(address), ExceptionFieldNullable);
    }

    public void UpdateEmail(Email email)
    {
        Email = email ?? throw new ArgumentNullException(nameof(email), ExceptionFieldNullable);
    }

    public void UpdatePhoneNumber(PhoneNumber phone)
    {
        PhoneNumber = phone ?? throw new ArgumentNullException(nameof(phone), ExceptionFieldNullable);
    }

    public void UpdateSalary(Money salary)
    {
        Salary = salary ?? throw new ArgumentNullException(nameof(salary), ExceptionFieldNullable);
    }
    
}