using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VARGAS_ROSELL_T3.WEB.Models;

namespace VARGAS_ROSELL_T3.WEB.BaseDatos.Maps
{
    public class RazaMap : IEntityTypeConfiguration<Raza>
    {
        public void Configure(EntityTypeBuilder<Raza> builder)
        {
            builder.ToTable("Raza");
            builder.HasKey(o => o.IdRaza);

            builder.HasMany(o => o.Animales).
             WithOne(o => o.Razas).
             HasForeignKey(o => o.IdRaza);
        }
    }
}
