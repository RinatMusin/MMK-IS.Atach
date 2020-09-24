using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class RouteStepGroupMap : IEntityTypeConfiguration<RouteStepGroup>
    {
        public void Configure(EntityTypeBuilder<RouteStepGroup> builder)
        {
            builder.HasKey(t => t.RouteStepGroupId);

            builder.ToTable("Route_Step_Group");

            builder.Property(t => t.CardId).HasColumnName("CardId");
            builder.Property(t => t.AfterSendCardId).HasColumnName("AfterSendCardId");
            builder.Property(t => t.RouteStepTypeId).HasColumnName("RouteStepTypeId");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Duration).HasColumnName("Duration");
            builder.Property(t => t.DocumentStatusId).HasColumnName("DocumentStatusId");
            builder.Property(t => t.IsStepRequired).HasColumnName("IsStepRequired");
            builder.Property(t => t.OnInMethodGroupId).HasColumnName("OnInMethodGroupId");
            builder.Property(t => t.OnOutMethodGroupId).HasColumnName("OnOutMethodGroupId");
            builder.Property(t => t.RouteActionId).HasColumnName("RouteActionId");
            builder.Property(t => t.IsCreateInNewVersion).HasColumnName("IsСreateInNewVersion");
            builder.Property(t => t.IsParallelEditable).HasColumnName("IsParallelEditable");



            builder.HasRequired(t => t.Card)
                .WithMany(t => t.RouteStepGroups)
                .HasForeignKey(t => t.CardId)
                .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.AfterSendCard)
                .WithMany(t => t.AfterRouteStepGroups)
                .HasForeignKey(t => t.AfterSendCardId)
                .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.RouteStepType)
                .WithMany(t => t.RouteStepGroups)
                .HasForeignKey(t => t.RouteStepTypeId)
                .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.RouteAction)
               .WithMany(t => t.OutRouteStepGroups)
               .HasForeignKey(t => t.RouteActionId)
                .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.OnInMethodGroup)
                .WithMany(t => t.RouteStepGroupsIn)
                .HasForeignKey(t => t.OnInMethodGroupId)
                .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.OnOutMethodGroup)
                .WithMany(t => t.RouteStepGroupsOut)
                .HasForeignKey(t => t.OnOutMethodGroupId)
                .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.DocumentStatus)
                 .WithMany(t => t.RouteStepGroups)
                 .HasForeignKey(t => t.DocumentStatusId)
                 .WillCascadeOnDelete(false);
        }
    }
}
