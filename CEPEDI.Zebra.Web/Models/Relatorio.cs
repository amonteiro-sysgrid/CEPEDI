using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CEPEDI.Zebra.Web.Models
{
    public class Relatorio : Base
    {
        //Identificacao
        public string Codigo { get; set; }
        public string Nome { get; set; }
        //Configuracao
        public Margem Margens { get; set; }
        public Dimensao Dimensoes { get; set; }
        public int Colunas { get; set; }
        public int Linhas { get; set; }
        //Comandos
        public string Arquivo { get; set; }
        public string Layout { get; set; }
        //Parametros
        internal string _Parametros { get; set; }
        [NotMapped]
        public string[] Parametros
        {
            get { return _Parametros == null ? null : JsonConvert.DeserializeObject<string[]>(_Parametros); }
            set { _Parametros = JsonConvert.SerializeObject(value); }
        }
        
        public Impressora Impressora { get; set; }
    }
}