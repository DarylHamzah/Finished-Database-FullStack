using WebApplication3.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication3.Server.Configurations.Entities
{
    public class MenuItemSeedConfiguration : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MenuItem> builder)
        {

            builder.HasData(
                 new MenuItem
                 {
                     Id = 1,
                     Name = "ChickenRice",
                     Price=5,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new MenuItem
                 {
                     Id = 2,
                     Name = "Laksa",
                     Price = 8,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
                 );

        }
    }
}
