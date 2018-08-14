using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CEPEDI.Zebra.Web.Models
{
    [ComplexType]
    public class Margem
    {
        public int Superior { get; set; }
        public int Inferior { get; set; }
        public int Direita { get; set; }
        public int Esquerda { get; set; }
    }
}