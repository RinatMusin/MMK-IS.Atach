using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class RouteStepMap : IEntityTypeConfiguration<RouteStep>
    {
        public void Configure(EntityTypeBuilder<RouteStep> builder)
        {
            builder.HasKey(t => t.RouteStepId);

            builder.ToTable("Route_Step");

            builder.Property(t => t.RouteId).HasColumnName("RouteId");
            builder.Property(t => t.RouteStepGroupId).HasColumnName("RouteStepGroupId");
            builder.Property(t => t.RouteStepTemplateId).HasColumnName("RouteStepTemplateId");
            builder.Property(t => t.UserId).HasColumnName("UserId");
            builder.Property(t => t.GroupId).HasColumnName("GroupId");
            builder.Property(t => t.TaskId).HasColumnName("TaskId");
            builder.Property(t => t.RouteActionId).HasColumnName("RouteActionId");
            builder.Property(t => t.BeforeCardId).HasColumnName("CardId");
            builder.Property(t => t.AfterSendCardId).HasColumnName("AfterSendCardId");

            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
            builder.Property(t => t.ParallelOrder).HasColumnName("ParallelOrder");
            builder.Property(t => t.GroupOrder).HasColumnName("GroupOrder");

            builder.Property(t => t.Duration).HasColumnName("Duration");
            builder.Property(t => t.PlannedDate).HasColumnName("PlannedDate");
            builder.Property(t => t.CreationDate).HasColumnName("CreationDate");

            builder.Property(t => t.StepTypeId).HasColumnName("StepTypeId");

            builder.Property(t => t.IsEditable).HasColumnName("IsEditable");
            builder.Property(t => t.IsRequired).HasColumnName("IsRequired");
            builder.Property(t => t.IsPassed).HasColumnName("IsPassed");
            builder.Property(t => t.IsVisible).HasColumnName("IsVisible");
            builder.Property(t => t.WasRecalled).HasColumnName("WasRecalled");

            builder.HasRequired(t => t.RouteStepGroup)
                .WithMany(t => t.RouteSteps)
                .HasForeignKey(t => t.RouteStepGroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasRequired(t => t.Route)
                .WithMany(t => t.RouteSteps)
                .HasForeignKey(t => t.RouteId)
                .WillCascadeOnDelete(true);

            builder.HasOne(t => t.User)
                .WithMany(t => t.RouteSteps)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasRequired(t => t.RouteStepType)
                .WithMany(t => t.RouteSteps)
                .HasForeignKey(t => t.StepTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.RouteAction)
                .WithMany(t => t.RouteSteps)
                .HasForeignKey(t => t.RouteActionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.BeforeCard)
                .WithMany(t => t.RouteSteps)
                .HasForeignKey(t => t.BeforeCardId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.AfterSendCard)
                .WithMany(t => t.AfterSendRouteSteps)
                .HasForeignKey(t => t.AfterSendCardId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.TaskEntity)
                .WithMany(t => t.RouteSteps)
                .HasForeignKey(t => t.TaskId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Group)
                .WithMany(t => t.RouteSteps)
                .HasForeignKey(t => t.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.TargetType)
                .WithMany(t => t.RouteSteps)
                .HasForeignKey(t => t.TargetTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.File)
                .WithMany(t => t.RouteSteps)
                .HasForeignKey(t => t.NoteFileId)
                .WillCascadeOnDelete(true);

            builder.HasOne(t => t.RouteStepTemplate)
                .WithMany(t => t.RouteSteps)
                .HasForeignKey(t => t.RouteStepTemplateId);
        }
    }

}