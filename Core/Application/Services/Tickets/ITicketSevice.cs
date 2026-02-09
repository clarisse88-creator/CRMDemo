using Application.DTO;
using Domain.Entities;

namespace  Application.Services.Tickets
{
    public interface ITicketService
    {
     List<Ticket> GetAllTickets();
     Ticket GetTicketById(int Id);

      void CreateTicket(TicketCreateDTO ticketDTO);
        void UpdateTicket(int Id, TicketUpdateDTO ticketDTO);
    }
}