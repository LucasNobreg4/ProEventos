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
                Local = "Curado 4",
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                Tema = "Curso .Net e Angular",
                QtdPessoas = 200,
                Lote = "Primeiro lote",
                ImagemURL = "dmwidoiawmdoim"

                },
                new Evento(){
                EventoId = 2,
                Local = "Curado 9",
                DataEvento = DateTime.Now.AddDays(3).ToString(),
                Tema = "Curso .Net e Angular",
                QtdPessoas = 240,
                Lote = "Primeiro lote",
                ImagemURL = "dmwidoiawmdoim"
                }
            };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> GetEventos()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetEventosById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string CadastraEvento()
        {
            return "Evento Cadastrado";
        }

        [HttpPut("{id}")]

        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]

        public string DeleteComId(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
