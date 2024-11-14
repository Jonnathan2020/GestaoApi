using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoApi.Models
{
    public class Equipamento
    {
        public int NumSerie { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Modelo{ get; set; }
        public string Acessorios { get; set; }
        public string Defeito { get; set; }
        public Cliente IdCLiente { get; set; }
        public OrdemServico IdOrdemServico { get; set; }
    }
}