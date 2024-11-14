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
    public class EquipamentoController : ControllerBase
    {  
        private static List<Equipamento> equipamentos = new List<Equipamento>()
        {
            new Equipamento() {NumSerie = 5432414, Nome= "Computador", Marca = "Dell", Modelo = "D100I9", Acessorios = "Cabo AC", Defeito= "Não reconhece HD"},
            new Equipamento() {NumSerie = 5432156, Nome= "Notebook", Marca = "Apple", Modelo = "Macbook01", Acessorios = "Fonte externa", Defeito= "Realizar revisão"},
            new Equipamento() {NumSerie = 8975234, Nome= "Impressora", Marca = "Samsung", Modelo = "S1000", Acessorios = "Cabo AC, Cabo usb", Defeito= "Não imprime colorido"},
            new Equipamento() {NumSerie = 8456466, Nome= "Impressora", Marca = "Epson", Modelo = "EP1000", Acessorios = "Sem Acessorios", Defeito= "Não imprime colorido"}
        };
        
        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            Equipamento e = equipamentos[0];
            return Ok(e);
        }


        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(equipamentos);
        }


        [HttpGet("{NumSerie}")]
        public IActionResult Get(int NumSerie)
        {
            return Ok(equipamentos.FirstOrDefault(equip => equip.NumSerie == NumSerie));
        }

        [HttpPost]
        public IActionResult AddEquipamentos(Equipamento novoEquipamento)
        {
            if (novoEquipamento.NumSerie == 0)
                return BadRequest("Numero de serie não pode ter o valor igual a 0 (zero).");

            /*
            if (novoCliente. == 0)
                return BadRequest("Numero de celular não pode ter o valor igual a 0 (zero).");
            */
            equipamentos.Add(novoEquipamento);
            return Ok(equipamentos);
        }
    }
}