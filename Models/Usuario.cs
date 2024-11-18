using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty; //É possível que seja criado como nulo
        public byte[]? PasswordHash { get; set; } //array de senha com conteudo totalmente criptografado "?" = aceita que seja Null
        public byte[]? PasswordSalt { get; set; } //array de senha com conteudo totalmente criptografado "?" = aceita que seja Null
        public byte[]? Foto { get; set; } //array de bytes, coluna com bastante texto em hexadecimal "?" = aceita que seja Null
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime? DataAcesso { get; set; }

        [NotMapped] //Não será mapeado, consequentemente nao sera gerado uma coluna no banco de dados. Utilizado na api para fins de teste
        public string PasswordString { get; set; } = string.Empty;
        public string Perfil { get; set;} = string.Empty;
        public string? Email { get; set; }
    }
}