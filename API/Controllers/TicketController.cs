using Microsoft.AspNetCore.Mvc;

using Application.Services.Tickets;
using Domain.Entities;
using Application.DTO;

namespace APICRMDemo.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet ("/api/tickets")]
        public IEnumerable<Ticket> GetTickets()
        {
            return _ticketService.GetAllTickets(new TicketFilterDTO(){});          
        }


        [HttpGet ("/api/tickets/{id}")]
        public Ticket GetTicketById(int id)
        {
            return _ticketService.GetTicketById(id);
            
        }

        [HttpPost ("/api/Tickets")]
        public IActionResult CreateTicket([FromBody] TicketCreateDTO ticketDTO)
        {
             _ticketService.CreateTicket(ticketDTO);
             return Ok();
        }
    } 
