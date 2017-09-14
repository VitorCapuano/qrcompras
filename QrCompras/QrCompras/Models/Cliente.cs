using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QRCompras.Models
{
    public class Cliente
    {
        public int id_socio;
        public int cpf;
        public string nome { get; set; }
        public DateTime dt_nascimento { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public bool tipo { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}