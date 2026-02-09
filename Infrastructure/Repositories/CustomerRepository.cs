using Application.DTO;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;
namespace Infrastructure.Repositories
{
    public class CustomerRepository : ICustomer
    {
        private readonly ApplicationDbContext dbContext;
        public CustomerRepository(ApplicationDbContext context)
        {
           dbContext=context; 
        }
        // Repository for retrieving customer data
        public List<Customer> GetAllCustomers()
        {
          List<Customer> customers = dbContext.Customers.ToList();
          return customers;
        }
        public Customer GetCustomerById(int Id)
        {
            return  dbContext.Customers.FirstOrDefault(c => c.Id == Id);
        }
        public void CreateCustomer(CustomerCreateDTO customerDTO)
        {
            var customer = new Customer
            {
                Name = customerDTO.Name,
                Email = customerDTO.Email,
                PhoneNumber = customerDTO.PhoneNumber,
                Address = customerDTO.Address,
                City = customerDTO.City,
                Type = customerDTO.Type,
                CreatedById=1,
                CreatedAt = DateTime.Now,
                Status = "Active"

            };
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
        }
        public void UpdateCustomer(int Id,CustomerUpdateDTO customerDTO)
        {
            var Customer = dbContext.Customers.Find(Id);
            if (Customer != null)
            {
                Customer.Name = customerDTO.Name;
                Customer.PhoneNumber = customerDTO.PhoneNumber;
                Customer.Address = customerDTO.Address;
                Customer.City = customerDTO.City;
                Customer.Type = customerDTO.Type;
                Customer.UpdatedById = 1;
                Customer.UpdatedAt = DateTime.Now;
                
                dbContext.SaveChanges();
            }
        }
}
    }   
    
    
        