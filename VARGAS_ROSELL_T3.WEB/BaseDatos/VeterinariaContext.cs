using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VARGAS_ROSELL_T3.WEB.BaseDatos.Maps;
using VARGAS_ROSELL_T3.WEB.Models;

namespace VARGAS_ROSELL_T3.WEB.BaseDatos
{
    public class VeterinariaContext : DbContext
    {
  
        public DbSet<Especie> _especie { get; set; }
        public DbSet<Sexo> _sexo { get; set; }
        public DbSet<Raza> _raza { get; set; }
        public DbSet<Animal> _Animales { get; set; }
        public DbSet<Usuario> _Usuarios { get; set; }
       


        public VeterinariaContext(DbContextOptions<VeterinariaContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EspecieMap());
            modelBuilder.ApplyConfiguration(new SexoMap());
            modelBuilder.ApplyConfiguration(new RazaMap());
            modelBuilder.ApplyConfiguration(new AnimalMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}