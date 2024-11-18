using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoApi.Models.Enuns
{
    public enum StatusEnum
    {
        Gerada = 1,
        Andamento = 2, 
        Pausada = 3,
        Cancelada = 4,
        Finalizada = 5
    }
}