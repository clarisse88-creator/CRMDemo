
using Application.DTO;
using Domain.Entities;


namespace Application.Services.Users
 {
   public interface IIdentityService 
    {
         public Task RegisterUser (RegisterUserDTO  dto);

    }
}