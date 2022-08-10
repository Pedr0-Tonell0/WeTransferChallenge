using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace WeTransfer.ViewModel
{
    public class VMFileUpload
    {
        [DataType(DataType.Upload)]
        [Required]
        public IFormFile File { get; set; }
        public Dictionary<int, string> ListaErrores { get; set; }
        public int OkDiv { get; set; }
        public int ErrorDiv { get; set; }
        public VMFileUpload()
        {
            OkDiv = 0;
            ErrorDiv = 0;
            ListaErrores = new Dictionary<int, string>();
            ListaErrores.Add(0, "");
            ListaErrores.Add(1, "Es obligatorio cargar un archivo");
            ListaErrores.Add(2, "La extensión del archivo debe ser .csv");
            ListaErrores.Add(3, "Ha ocurrido un error procesando el archivo");
        }
    }
}
