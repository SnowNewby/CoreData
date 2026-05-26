using CoreData.DTO.Domain.Interfaces;
using CoreData.DTO.Domain.models;
using CoreData.DTO.Domain.ValueObjects;

namespace CoreData.DTO.Domain.Services;

public class UserService
{
    protected readonly IUserRepository _userRepository;
    
    // TODO: Добавить дополнительную бизнес логику
    public User GetId(string id)
    {
        return _userRepository.GetId(id);
    }

    public User GetEmail(Email email)
    {
        return _userRepository.GetEmail(email);
    }

    public List<User> GetAll()
    {
        return _userRepository.GetAll();
    }

    public void Add(User user)
    {
        _userRepository.Add(user);
    }

    public void Update(User user)
    {
        _userRepository.Update(user);
    }

    public void Delete(User user)
    {
        _userRepository.Delete(user);
    }
}