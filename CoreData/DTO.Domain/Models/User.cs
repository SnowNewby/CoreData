using CoreData.DTO.Domain.ValueObjects;

namespace CoreData.DTO.Domain.models;

public class User
{
    public string Id { get; private set; }
    public string Username {get; private set;}
    public Email Email {get; private set;}
    public PhoneNumber PhoneNumber {get; private set;}
}