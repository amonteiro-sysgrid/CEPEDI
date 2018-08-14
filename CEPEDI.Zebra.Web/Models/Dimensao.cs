using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CEPEDI.Zebra.Web.Models
{
    [ComplexType]
    public class Dimensao
    {
        public int Altura { get; set; }
        public int Largura { get; set; }
    }
}