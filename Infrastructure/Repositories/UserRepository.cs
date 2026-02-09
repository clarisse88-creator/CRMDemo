using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;
using Application.DTO;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext dbContext;
        public UserRepository(ApplicationDbContext context)
        {
           dbContext=context; 
        }
        // Repository for retrieving user data
        public List<User> GetAllUsers()
        {
          List<User> users = dbContext.Users.ToList();
          return users;
        }
        public User GetUserById(int Id)
        {
            return  dbContext.Users.FirstOrDefault(c => c.Id == Id);
        }
        public void CreateUser(UserCreateDTO userDTO)
        {
            var user = new User
            {
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                Email = userDTO.Email,
                PhoneNumber = userDTO.PhoneNumber,
                Password = userDTO.Password,
                Role = userDTO.Role,
                // CreatedBy=userDTO.CreatedBy,

            };
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
        public void UpdateUser(int Id,UserUpdateDTO userDTO)
        {
            var user = dbContext.Users.Find(Id);
            if (user != null)
            {
                user.FirstName = userDTO.FirstName;
                user.LastName = userDTO.LastName;
                user.PhoneNumber = userDTO.PhoneNumber;
                user.Password = userDTO.Password;
                user.Role = userDTO.Role;
                // user.UpdatedBy=userDTO.UpdatedBy;
              
            }
            dbContext.SaveChanges();
        }
            
    }
}
      
    
    
        