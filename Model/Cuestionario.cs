using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Cuestionario
    {
        [Key]
        public int Id { get; set; }
        public string Pregunta { get; set; }
    }
}
