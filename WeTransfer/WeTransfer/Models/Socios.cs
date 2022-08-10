using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeTransfer.Models
{
    public class Socios
    {
        [Key]
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public int Edad { get; set; }
        public string Equipo { get; set; }
        public string EstadoCivil { get; set; }
        public string Estudios { get; set; }

    }
}
