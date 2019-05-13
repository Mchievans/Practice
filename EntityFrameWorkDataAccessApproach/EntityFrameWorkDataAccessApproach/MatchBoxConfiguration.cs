using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;

namespace EntityFrameWorkDataAccessApproach
{
    class MatchBoxConfiguration : IEntityTypeConfiguration<MatchBox>
    {
        public void Configure(EntityTypeBuilder<MatchBox> builder)
        {
            builder.HasKey(mb => mb.CarId);
            builder.Property(mb => mb.CarId).UseSqlServerIdentityColumn();                     
        }
    }
}
