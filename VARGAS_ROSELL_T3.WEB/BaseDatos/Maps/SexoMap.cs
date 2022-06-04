using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VARGAS_ROSELL_T3.WEB.Models;

namespace VARGAS_ROSELL_T3.WEB.BaseDatos.Maps
{
    public class SexoMap : IEntityTypeConfiguration<Sexo>
    {
        public void Configure(EntityTypeBuilder<Sexo> builder)
        {
            builder.ToTable("Sexo");
            builder.HasKey(o => o.IdSexo);

            builder.HasMany(o => o.Animales).
             WithOne(o => o.Sexos).
             HasForeignKey(o => o.IdSexo);
        }
    }
}
