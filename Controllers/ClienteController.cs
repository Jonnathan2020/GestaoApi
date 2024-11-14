using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestaoApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ClienteController : ControllerBase
    {
        private static List<Cliente> clientes = new List<Cliente>()
        {
            new Cliente() { Id = 1, Nome = "Jonnathan", Sobrenome = "Santos", Cpf = "46881735070", Celular = 11999988877, Endereco = "Rua Napoleao", EndNum = 1543, Bairro = "Vila Guilherme", Cidade = "São Paulo", UF = "SP"},
            new Cliente() { Id = 2, Nome = "Amadeu", Sobrenome = "Romusvaldo", Cpf = "5717425885", Celular = 11991492477, Endereco = "Rua Seilandia", EndNum = 23, Bairro = "Seilandia", Cidade = "São Paulo", UF = "SP"},
            new Cliente() { Id = 3, Nome = "Abel", Sobrenome = "Santo", Cpf = "12345678901", Celular = 1199988776655, Endereco = "Rua da irmandadde", EndNum = 50, Bairro = "Vila Armadada", Cidade = "São Paulo", UF = "SP"},
            new Cliente() { Id = 2, Nome = "Magno", Sobrenome = "Magnanimo", Cpf = "52875298410", Celular = 11923492477, Endereco = "Rua quarteto", EndNum = 153, Bairro = "X-men", Cidade = "São Paulo", UF = "SP"},
        };

        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            Cliente c = clientes[0];
            return Ok(c);
        }


        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(clientes);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(clientes.FirstOrDefault(client => client.Id ==id));
        }

        [HttpPost]
        public IActionResult AddCliente(Cliente novoCliente)
        {
            if (novoCliente.Celular == 0)
                return BadRequest("Numero de celular não pode ter o valor igual a 0 (zero).");

            /*
            if (novoCliente. == 0)
                return BadRequest("Numero de celular não pode ter o valor igual a 0 (zero).");
            */
            clientes.Add(novoCliente);
            return Ok(clientes);
        }
        
    }
}