using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QRCompras.Models
{
    public class Produto
    {
        public int ean { get; set; }
        public double valor { get; set; }
        public string descricao { get; set; }

        public Parceiro parceiro { get; set; }
    }
}