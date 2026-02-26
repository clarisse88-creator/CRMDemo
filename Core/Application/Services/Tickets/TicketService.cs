using  Domain.Entities; 
using Application.Interface;
using Application.DTO;

namespace Application.Services.Tickets
{
    public class TicketService : ITicketService
    {
         private readonly ITicket Ticket;

        //constructor 
        public TicketService(ITicket tickets)
        {
            Ticket = tickets;
        }
        public List<Ticket> GetAllTickets( TicketFilterDTO filter)
        {
         List<Ticket> tickets = Ticket.GetAllTickets(filter);
         return tickets;
        }
       public Ticket GetTicketById(int Id)
        {
         return Ticket.GetTicketById(Id);
        }
        public void CreateTicket(TicketCreateDTO ticketDTO)
        {
         Ticket.CreateTicket( ticketDTO);
        }
        public void UpdateTicket(int Id, TicketUpdateDTO ticketDTO)
        {
            Ticket.UpdateTicket(Id, ticketDTO);
    }
    }
}