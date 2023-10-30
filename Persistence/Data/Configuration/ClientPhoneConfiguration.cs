using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ClientPhoneConfiguration : IEntityTypeConfiguration<ClientPhone>
    {
        public void Configure(EntityTypeBuilder<ClientPhone> builder)
        {
            builder.ToTable("ClientPhone");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.Number)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.Clients)
            .WithMany(p => p.ClientPhones)
            .HasForeignKey(p => p.IdClient);
        }
    }
}