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
        public List<Customer> GetAllCustomers( CustomerFilterDTO filter)
        {
           IQueryable<Customer> query = dbContext.Customers;
            if(!string.IsNullOrEmpty(filter.SearchTerm))
            {
                query = query.Where(c => c.Name.Contains(filter.SearchTerm));
            }
            if(!string.IsNullOrEmpty(filter.City))
            {
                query = query.Where(c => c.City.Contains(filter.City));
            }

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
        public  List<CityCountDTO> GetCityCustomerCityByCity()
        {
            return dbContext.Customers
            .GroupBy(t => t.City)
            .Select(g =>new CityCountDTO
            {
               city =g .Key,
               Count = g.Count() 
            })
            .ToList();
        }
}
    }   
    
    
        