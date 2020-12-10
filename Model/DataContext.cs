using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {
                
        }

        public DbSet<Administradores> Administradores { get; set; }
        public DbSet<Cuestionario> Cuestionario { get; set; }
        public DbSet<Diagnosticos> Diagnosticos { get; set; }
        public DbSet<Historias> Historias { get; set; }
        public DbSet<Pacientes> Pacientes { get; set; }
        public DbSet<Doctores> Psicologos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }


    }

}
