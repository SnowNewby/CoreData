using CoreData.DTO.Domain.ValueObjects;

namespace CoreData.DTO.Domain.models;

public class User
{
    public string Id { get; private set; }
    public string Username {get; private set;}
    public string FirstName {get; private set;}
    public string LastName {get; private set;}
    public string Gender {get; private set;}
    
    public Email Email {get; private set;}
    public PhoneNumber PhoneNumber {get; private set;}
    public Money Salary {get; private set;}
    public Address Address {get; private set;}
    
}