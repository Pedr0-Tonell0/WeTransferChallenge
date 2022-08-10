using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace WeTransfer.Data
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> opciones) : base(opciones) { }
        public DbSet <Models.Socios> Socios { get; set; }
    }
}
