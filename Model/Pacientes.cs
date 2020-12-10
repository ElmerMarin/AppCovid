using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class Pacientes
    {

        public int IdPaciente { get; set; }
        [Key]
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }

        [ForeignKey("Usuarios")]
        public int IdUsuario { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Diagnosticos> Diagnosticos { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
