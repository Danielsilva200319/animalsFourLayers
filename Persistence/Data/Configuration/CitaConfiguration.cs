using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class CitaConfiguration : IEntityTypeConfiguration<Cita>
    {
        public void Configure(EntityTypeBuilder<Cita> builder)
        {
            builder.ToTable("Cita");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Date)
            .HasColumnType("date");

            builder.Property(p => p.Hour)
            .HasColumnType("time");

            builder.HasOne(p => p.Clients)
            .WithMany(p => p.Citas)
            .HasForeignKey(p => p.IdClient);

            builder.HasOne(p => p.Pets)
            .WithMany(p => p.Citas)
            .HasForeignKey(p => p.IdPet);

            builder.HasOne(p => p.Services)
            .WithMany(p => p.Citas)
            .HasForeignKey(p => p.IdService);
        }
    }
}