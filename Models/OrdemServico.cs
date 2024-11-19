using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoApi.Models.Enuns;

namespace GestaoApi.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public int DataCriacao { get; set; }
        public int DataAvaliacao { get; set; }
        public int DataFinalizacao { get; set; }
        public int DataEntrega { get; set; }
        public string Atividade { get; set; }
        public int ValorServico { get; set; }
        public StatusEnum? status { get; set; }
        public int TecnicoId { get; set; }
        public Tecnico Tecnico { get; set;}
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int EquipamentoId { get; set; } // Chave estrangeira
        public Equipamento Equipamento { get; set; } // Propriedade de navegação
        public ICollection<OrdemEquipamento> OrdemEquipamentos { get; set;}
    }
}