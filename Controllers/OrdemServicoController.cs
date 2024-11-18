using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestaoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdemServicoController : ControllerBase
    {
        private static List<OrdemServico> ordemServicos = new List<OrdemServico>()
        {
            new OrdemServico() { Id = 1, status = Models.Enuns.StatusEnum.Finalizada, Atividade = "Substituido HD", DataCriacao = 10112024, DataAvaliacao = 10112024, DataFinalizacao = 12112024, DataEntrega = 13112024, ValorServico = 350 },
            new OrdemServico() { Id = 2, status = Models.Enuns.StatusEnum.Finalizada, Atividade = "Revisado e testado", DataCriacao = 10112024, DataAvaliacao = 10112024, DataFinalizacao = 13112024, DataEntrega = 13112024, ValorServico = 950 }
        };


        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            OrdemServico OS = ordemServicos[0];
            return Ok(OS);
        }


        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(ordemServicos);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(ordemServicos.FirstOrDefault(OS => OS.Id ==id));
        }

        [HttpPost]
        public IActionResult AddOrdemServico(OrdemServico novaOrdemServico)
        {
            if (novaOrdemServico.Id == 0)
                return BadRequest("Numero de OS não pode ter o valor igual a 0 (zero).");

            /*
            if (novoCliente. == 0)
                return BadRequest("Numero de celular não pode ter o valor igual a 0 (zero).");
            */
            ordemServicos.Add(novaOrdemServico);
            return Ok(ordemServicos);
        }
    }
}