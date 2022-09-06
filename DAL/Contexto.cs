using Microsoft.EntityFrameworkCore;
using RegistroDeOcupaciones.Models;

namespace RegistroDeOcupaciones.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Ocupaciones> Ocupaciones { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
    }
}