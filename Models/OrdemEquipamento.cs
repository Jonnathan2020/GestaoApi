using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoApi.Models
{
    public class OrdemEquipamento
    {
        public int OrdemId { get; set; } // Chave estrangeira para OrdemServico
        public int NumSerie { get; set; } // Chave estrangeira para Equipamento

        // Propriedade de navegação para a entidade OrdemServico
        public OrdemServico OrdemServico { get; set; }

        // Propriedade de navegação para a entidade Equipamento
        public Equipamento Equipamento { get; set; }

    }
}