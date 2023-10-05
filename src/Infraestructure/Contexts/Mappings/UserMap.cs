using GoldenPaths.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenPaths.Infraestructure.Contexts.Mappings
{
    internal class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany<Demand>(x=> x.Demands).WithMany(x => x.Users);
        }
    }

    internal class DemandMap : IEntityTypeConfiguration<Demand>
    {
        public void Configure(EntityTypeBuilder<Demand> builder)
        {
            builder.HasKey(x=> x.Id);
        }
    }

    internal class DemandStatusMap : IEntityTypeConfiguration<DemandStatus>
    {
        public void Configure(EntityTypeBuilder<DemandStatus> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }

    internal class DemandTypeMap : IEntityTypeConfiguration<DemandType>
    {
        public void Configure(EntityTypeBuilder<DemandType> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }

    internal class PhotoMap : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
    internal class PlaceMap : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasOne<Address>().WithOne(x => x.Place).HasForeignKey<Place>(x => x.AddressId).HasPrincipalKey<Address>(x=> x.Id);
        }
    }

    internal class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne<Place>(x=> x.Place).WithOne(x => x.Address).HasForeignKey<Place>(x => x.AddressId).HasPrincipalKey<Address>(x=> x.Id);
        }
    }
}
