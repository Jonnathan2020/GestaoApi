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
        public Tecnico? TecnicoId { get; set; }
        public Cliente? ClienteId { get; set; }
        public Equipamento? EquipamentoId { get; set; }
        public StatusEnum? status { get; set; }
    }
}