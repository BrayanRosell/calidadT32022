using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VARGAS_ROSELL_T3.WEB.Models;

namespace VARGAS_ROSELL_T3.WEB.BaseDatos
{
    public class EspecieMap : IEntityTypeConfiguration<Especie>
    {
        public void Configure(EntityTypeBuilder<Especie> builder)
        {
            builder.ToTable("Especie");
            builder.HasKey(o => o.IdEspecie);

            builder.HasMany(o => o.Animales).
             WithOne(o => o.Especies).
             HasForeignKey(o => o.IdEspecie);
        }
    }
}
