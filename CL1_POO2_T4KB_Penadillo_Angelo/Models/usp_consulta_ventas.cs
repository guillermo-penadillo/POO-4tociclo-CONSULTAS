using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CL1_POO2_T4KB_Penadillo_Angelo.Models
{
    public class usp_consulta_ventas
    {
        public string num_vta { get; set; }
        public string fec_vta { get; set; }
        public string nom_art { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public decimal Total { get; set; }
    }
}