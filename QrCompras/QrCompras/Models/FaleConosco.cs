using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QRCompras.Models
{
    public class FaleConosco
    {
        public string Assunto { get; set; }
        public string Email { get; set; }
        public string Mensagem
        {
            get; set;
        }
    }
}