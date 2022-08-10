using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeTransfer.Models;

namespace WeTransfer.Repository
{
    public class HomeRepository : IHomeRepository
    {
        private readonly Data.Contexto _contexto;
        public HomeRepository(Data.Contexto contexto)
        {
            _contexto = contexto;
        }
        public void AddSocio(IEnumerable<Socios> socios)
        {
            foreach (var item in socios)
            {
                _contexto.Socios.Add(item);
            }
            _contexto.SaveChanges();
        }

        public int GetCantidadSocios()
        {
            var cantidad = (from c in _contexto.Socios
                            select c).Count();
            return cantidad;
        }

        public double GetPromedioSociosRacing()
        {
            int total = (from c in _contexto.Socios
                         where c.Equipo == "Racing"
                         select c).Count();
            double cantidad = (from c in _contexto.Socios
                               where c.Equipo == "Racing"
                               select c.Edad).Sum();
            double promedio = cantidad / total;
            return promedio;
        }

        public List<Socios> GetTop100()
        {
            var list = (from c in _contexto.Socios
                        where c.EstadoCivil == "Casado" &&
                        c.Estudios == "Universitario"
                        orderby c.Edad
                        select new Models.Socios { Nombre = c.Nombre, Edad = c.Edad, Equipo = c.Equipo }
                        ).Take(100);
            return list.ToList();
        }

        public List<Models.Socios> GetTop5()
        {
            var list = _contexto.Socios
                .Where(c => c.Equipo == "River")
                .GroupBy(c => new { c.Nombre })
                .Select(g => new Models.Socios
                {
                    Nombre = g.Key.Nombre,
                    Edad = g.Count()
                }).OrderByDescending(g => g.Edad).Take(5);

            return list.ToList();
        }

        public List<ViewModel.VMSocios> GetUltimoPunto()
        {
            var list = (from o in _contexto.Socios
                       group o by o.Equipo into p
                       select new ViewModel.VMSocios
                       {
                           Cantidad = p.Count(),
                           Promedio = p.Sum(x => x.Edad),
                           EdadMenor = p.Min(x => x.Edad),
                           EdadMayor = p.Max(x => x.Edad),
                           Equipo = p.Key,
                       }).OrderByDescending(x => x.Cantidad);
            return list.ToList();

        }
    }
}
