using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class GroupAssignMap : IEntityTypeConfiguration<GroupAssign>
    {
        public void Configure(EntityTypeBuilder<GroupAssign> builder)
        {
            builder.HasKey(t => t.GroupAssignId);

            builder.ToTable("Group_Assign");
            
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
            builder.Property(t => t.ClientProfileId).HasColumnName("ClientProfileId");
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");

            builder.HasRequired(t => t.ClientProfile)
                .WithMany(t => t.GroupAssigns)
                .HasForeignKey(t => t.ClientProfileId)
                .WillCascadeOnDelete(false);
        }
    }
}
