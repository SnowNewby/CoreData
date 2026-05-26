using CoreData.DTO.Domain.models;
using CoreData.DTO.Domain.ValueObjects;

namespace CoreData.DTO.Domain.Interfaces;

public interface IUserRepository
{
    User GetId(String id);
    
    User GetEmail(Email email);
    
    List<User> GetAll();
    
    void Add(User user);
    
    void Update(User user);
    
    void Delete(User user);
}