using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CEPEDI.Zebra.Web.Models
{
    public class Impressora : Base
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Path { get; set; }
        public Dimensao Ribbon { get; set; }
    }
}