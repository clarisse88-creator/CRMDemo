
using Application.DTO;
using Domain.Entities;


namespace Application.Interface.Users
 {
   public interface IIdentityService 
    {
  public Task RegisterUser (RegisterUserDTO  dto);


    }
}