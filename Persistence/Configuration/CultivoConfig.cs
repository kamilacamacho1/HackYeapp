using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration
{
    public class CultivoConfig : IEntityTypeConfiguration<Cultivo>
    {
        public void Configure(EntityTypeBuilder<Cultivo> builder)
        {
            builder.ToTable("Cultivo");
            builder.HasKey(p => p.id);
            builder.Property(p => p.Nombre).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
        }
    }
}
