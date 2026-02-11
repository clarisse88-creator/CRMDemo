
using Application.DTO;
using Domain.Entities;


namespace Application.Interface.Users
 {
   public interface IIdentityService 
    {
    void RegisterUser (RegisterUserDTO  dto);


    }
}