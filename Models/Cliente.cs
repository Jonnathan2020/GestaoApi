using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GestaoApi.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public long Celular { get; set; }
        public string Endereco  { get; set; }
        public int EndNum { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public Equipamento? EquipamentoId{ get; set; }
        public OrdemServico? OrdemId { get; set; }

        public static implicit operator Cliente(int v)
        {
            throw new NotImplementedException();
        }
    }
}