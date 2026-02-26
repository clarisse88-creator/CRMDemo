
using Application.DTO;
using Domain.Entities;

namespace Application.Interface
{
    public interface ICustomer
    {
        public List<Customer> GetAllCustomers(CustomerFilterDTO filter);
        public Customer GetCustomerById(int Id);
        void CreateCustomer(CustomerCreateDTO customerDTO);
        void UpdateCustomer(int Id, CustomerUpdateDTO customerDTO);
        List<CityCountDTO> GetCityCustomerCityByCity();
    }
}










