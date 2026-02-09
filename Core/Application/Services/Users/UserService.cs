using Application.Interface;
using  Domain.Entities;
using Application.DTO;
 
namespace Application.Services.Users
{
    public class UserService : IUserService
    {
    
        private readonly IUser User;

        //constructor 
        public UserService(IUser users)
        {
            User = users;
        }
        public List<User> GetAllUsers()
        {
         List<User> users = User.GetAllUsers();
         return users;
        }
       public User GetUserById(int Id)
        {
         return User.GetUserById(Id);
        }
        public void CreateUser(UserCreateDTO userDTO)
        {
          User.CreateUser(userDTO);
        }
        public void UpdateUser(int Id, UserUpdateDTO userDTO)
        {
            User.UpdateUser(Id, userDTO);
    }
    }
}
     
