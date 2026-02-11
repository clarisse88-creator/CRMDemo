
using Application.DTO;
using Domain.Entities;
namespace Application.Interface
{
    public interface IIdentity
    {
        public Task RegisterUser (RegisterUserDTO  dto);
    }
}