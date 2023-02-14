using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento(){
                EventoId = 1,
                Tema = "Angular",
                Local = "Belo H",
                Lote = "1",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.ToString(),
                ImagemURL = "foto.png"
            },
            new Evento(){
                EventoId = 2,
                Tema = "Angular 2",
                Local = "sp H",
                Lote = "1",
                QtdPessoas = 300,
                DataEvento = DateTime.Now.ToString(),
                ImagemURL = "foto2.png"
            }
        };


        private readonly ILogger<EventoController> _logger;

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

       [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost("{id}")]
        public string Post()
        {
            return "Post";
        }

        [HttpPut("{id}")]
        public string Put()
        {
            return "Put";
        }

        [HttpDelete("{id}")]
        public string Delete()
        {
            return "Delete";
        }
    }
}
