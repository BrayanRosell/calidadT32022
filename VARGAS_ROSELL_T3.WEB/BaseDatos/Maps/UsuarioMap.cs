using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VARGAS_ROSELL_T3.WEB.Models;

namespace VARGAS_ROSELL_T3.WEB.BaseDatos.Maps
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(o => o.IdUsuario);

            builder.HasMany(o => o.Animales).
             WithOne(o => o.Usuarios).
             HasForeignKey(o => o.IdUsuario);
        }
    }
}
