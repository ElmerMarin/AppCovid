using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class Historias
    {
        public int IdHistoria { get; set; }
        [Key]
        public int CodigoDiagnostico { get; set; }

        [ForeignKey("Doctores")]
        public string DniDoctor { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public string Tratamiento { get; set; }
        public string Observacion { get; set; }

        public virtual Diagnosticos Diagnosticos { get; set; }
    }
}
