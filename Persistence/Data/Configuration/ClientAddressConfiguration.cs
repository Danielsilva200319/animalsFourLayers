using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ClientAddressConfiguration : IEntityTypeConfiguration<ClientAddress>
    {
        public void Configure(EntityTypeBuilder<ClientAddress> builder)
        {
            builder.ToTable("ClientAddress");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.TypeRoad)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.NumberPri)
            .HasColumnType("int");

            builder.Property(p => p.Letter)
            .IsRequired()
            .HasMaxLength(1);

            builder.Property(p => p.Bis)
            .IsRequired()
            .HasMaxLength(3);

            builder.Property(p => p.LetterSec)
            .IsRequired()
            .HasMaxLength(2);

            builder.Property(p => p.Cardinal)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.NumberSec)
            .HasColumnType("int");

            builder.Property(p => p.LetterTer)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.NumberTer)
            .HasColumnType("int");

            builder.Property(p => p.CardinalSec)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.Complement)
            .HasMaxLength(50);

            builder.Property(p => p.PostalCode)
            .HasMaxLength(10);

            builder.HasOne(a => a.Clients)
            .WithOne(b => b.ClientAddresses)
            .HasForeignKey<ClientAddress>(b => b.IdClient);

            builder.HasOne(p => p.Cities)
            .WithOne(p => p.ClientAddresses)
            .HasForeignKey<ClientAddress>(p => p.IdCity);
        }
    }
}