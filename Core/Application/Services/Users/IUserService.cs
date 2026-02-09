
using Application.DTO;
using Domain.Entities;


namespace  Application.Services.Users
{
    public interface IUserService
    {
     User GetUserById(int Id);
    List<User> GetAllUsers();
     void CreateUser(UserCreateDTO userDTO);
     void UpdateUser(int Id, UserUpdateDTO userDTO);
    }
}