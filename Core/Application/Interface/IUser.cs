using Application.DTO;
using Domain.Entities;
namespace Application.Interface
{
    public interface IUser
    {
        public List<User> GetAllUsers();
        public User GetUserById(int Id);
        void CreateUser(UserCreateDTO userDTO);
        void UpdateUser(int Id, UserUpdateDTO userDTO);
    }
}










