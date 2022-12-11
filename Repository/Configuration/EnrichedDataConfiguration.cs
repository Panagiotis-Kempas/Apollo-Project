using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository.Configuration
{
    public class EnrichedDataConfiguration : IEntityTypeConfiguration<EnrichedData>
    {
        public void Configure(EntityTypeBuilder<EnrichedData> builder)
        {
           
        }
    }
}
