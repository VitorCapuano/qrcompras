using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QRCompras.Models
{
    public class Parceiro
    {
        public int id_PJ;
        public string razao_social { get; set; }
        public string cnpj { get; set; }
        public string telefone { get; set; }
        public string rua { get; set; }
        public string cep { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
    }
}