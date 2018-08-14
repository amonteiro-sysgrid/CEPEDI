using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CEPEDI.Zebra.Web.Models
{
    public abstract class Base
    {
        public Base()
        {
            Guid = Guid.NewGuid();
            Criacao = DateTime.Now;
            Atualizacao = DateTime.Now;
            Status = true;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Guid { get; set; }

        [DisplayName("Criação")]
        public DateTime Criacao { get; set; }
        [DisplayName("Atualização")]
        public DateTime Atualizacao { get; set; }
        public bool Status { get; set; }
    }
}