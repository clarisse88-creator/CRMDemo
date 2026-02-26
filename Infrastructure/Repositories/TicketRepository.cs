using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;
using Application.DTO;
namespace Infrastructure.Repositories
{
    public class TicketRepository : ITicket
    {
        private readonly ApplicationDbContext dbContext;
        public TicketRepository(ApplicationDbContext context)
        {
           dbContext=context; 
        }
        // Repository for retrieving ticket data
        public List<Ticket> GetAllTickets( TicketFilterDTO filter)
        {
            
          List<Ticket> tickets = dbContext.Tickets.ToList();
          return tickets;
        }
        public Ticket GetTicketById(int Id)
        {
            return  dbContext.Tickets.FirstOrDefault(t => t.Id == Id);
        }
         public void CreateTicket(TicketCreateDTO ticketDTO)
        {
            var ticket = new Ticket
            {
                CustomerId = ticketDTO.CustomerId,
                Subject = ticketDTO.Subject,
                Description = ticketDTO.Description,
                Status = ticketDTO.Status,
                CreatedAt = DateTime.Now,
                Priority = ticketDTO.Priority,
                Type = ticketDTO.Type,
                closedAt = ticketDTO.closedAt,
                CreatedById=1,
                

            };
            dbContext.Tickets.Add(ticket);
            dbContext.SaveChanges();
        }
        public void UpdateTicket(int Id,TicketUpdateDTO ticketDTO)
        {
            var ticket = dbContext.Tickets.Find(Id);
            if (ticket != null)
            {
                ticket.Subject = ticketDTO.Subject;
                ticket.Description = ticketDTO.Description;
                ticket.Status = ticketDTO.Status;
                ticket.CreatedAt = DateTime.Now;
                ticket.Priority = ticketDTO.Priority;
                ticket.Type = ticketDTO.Type;
                ticket.closedAt = ticketDTO.closedAt;
               
                ticket.UpdatedAt = DateTime.Now;

                dbContext.SaveChanges();
            }
        }
}
    }   
    
    
        