using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoApi.Models
{
    public class OrdemServico
    {
        public int IdOS { get; set; }
        public int DataCriacao { get; set; }
        public int DataAvaliacao { get; set; }
        public int DataFinalizacao { get; set; }
        public int DataEntrega { get; set; }
        public string status { get; set; }
        public string Atividade { get; set; }
        public int ValorServico { get; set; }
        public Tecnico tecnico { get; set; }
        public Cliente cliente { get; set; }
        public Equipamento equipamento { get; set; }
    }
}