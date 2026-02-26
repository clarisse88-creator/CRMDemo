using Application.Interface;
using  Domain.Entities;
using Application.DTO;
 
namespace Application.Services.Customers
{
    public class CustomerService : ICustomerService
    {
    
        private readonly ICustomer Customer;

        //constructor 
        public CustomerService(ICustomer customers)
        {
            Customer = customers;
        }
        public List<Customer> GetAllCustomers(CustomerFilterDTO filter)
        {
         List<Customer> customers = Customer.GetAllCustomers(filter);
         return customers;
        }
       public Customer GetCustomerById(int Id)
        {
         return Customer.GetCustomerById(Id);
        }
        public void CreateCustomer(CustomerCreateDTO customerDTO)
        {
         Customer.CreateCustomer( customerDTO);
        }
        public void UpdateCustomer(int Id, CustomerUpdateDTO customerDTO)
        {
            Customer.UpdateCustomer(Id, customerDTO);
        }
           public  List<CityCountDTO> GetCityCustomerCityByCity()
        {
            return Customer.GetCityCustomerCityByCity();
        }
    } 
}