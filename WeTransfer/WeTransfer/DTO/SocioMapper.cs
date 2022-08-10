using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyCsvParser.Mapping;

namespace WeTransfer.DTO
{
    public class SocioMapper : CsvMapping<Models.Socios>
    {
        public SocioMapper() : base()
        {
            MapProperty(0, x => x.Nombre);
            MapProperty(1, x => x.Edad);
            MapProperty(2, x => x.Equipo);
            MapProperty(3, x => x.EstadoCivil);
            MapProperty(4, x => x.Estudios);
        }
    }
}
