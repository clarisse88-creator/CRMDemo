using Application.DTO;
using Domain.Entities;
namespace Application.Interface
{
    public interface ITicket
    {
        public List<Ticket> GetAllTickets( TicketFilterDTO filter);
        public Ticket GetTicketById(int Id);
          void CreateTicket(TicketCreateDTO ticketDTO);
        void UpdateTicket(int Id, TicketUpdateDTO ticketDTO);
    }
}










