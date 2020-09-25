using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class GroupMap : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(t => t.GroupId);

            builder.ToTable("Group");

            builder.Property(t => t.Avatar).HasColumnName("Avatar");
            builder.Property(t => t.Duration).HasColumnName("Duration");
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar"); ;
        }
    }
}