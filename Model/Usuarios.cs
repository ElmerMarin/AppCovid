using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public string TipoUsuario { get; set; }
        public string Correo { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Token { get; set; }

        public virtual ICollection<Administradores> Administradores { get; set; }

        public virtual ICollection<Pacientes> Pacientes { get; set; }

        public virtual ICollection<Doctores> Doctores { get; set; }
    }
}
