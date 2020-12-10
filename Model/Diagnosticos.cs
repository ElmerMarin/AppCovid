using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class Diagnosticos
    {
        [Key]
        public int IdDiagnostico { get; set; }

        [ForeignKey("Pacientes")]
        public string DniPaciente { get; set; }
        public string Resultado { get; set; }
        public virtual Pacientes Pacientes { get; set; }
        public virtual ICollection<Historias> Historias { get; set; }
    }
}
