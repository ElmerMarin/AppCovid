using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class Administradores
    {
        public int IdAdministrador { get; set; }
        [Key]
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }

        [ForeignKey("Usuarios")]
        public int IdUsuario { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
