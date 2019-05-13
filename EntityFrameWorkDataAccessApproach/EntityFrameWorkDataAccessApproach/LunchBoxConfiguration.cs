using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameWorkDataAccessApproach
{
    class LunchBoxConfiguration : IEntityTypeConfiguration<LunchBox>
    {
        public void Configure(EntityTypeBuilder<LunchBox> builder)
        {
            builder.HasKey(lb => lb.LunchId);
            builder.Property(lb => lb.LunchId).UseSqlServerIdentityColumn();
        }
    }
}

