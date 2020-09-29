using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class RouteStepTypeConfiguration : IEntityTypeConfiguration<RouteStepType>
    {
        public void Configure(EntityTypeBuilder<RouteStepType> builder)
        {
            builder.HasKey(t => t.RouteStepTypeId);

            builder.ToTable("Route_Step_Type");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");

            builder.Property(t => t.OnAcceptTaskStatusId).HasColumnName("OnAcceptTaskStatusId");
            builder.Property(t => t.OnRejectTaskStatusId).HasColumnName("OnRejectTaskStatusId");
            builder.Property(t => t.OnCreateTaskStatusId).HasColumnName("OnCreateTaskStatusId");

            builder.Property(t => t.OnInMethodGroupId).HasColumnName("OnInMethodGroupId");
            builder.Property(t => t.OnOutMethodGroupId).HasColumnName("OnOutMethodGroupId");
            builder.Property(t => t.OnRejectMethodGroupId).HasColumnName("OnRejectMethodGroupId");


            builder.HasOne(t => t.OnCreateTaskStatus)
               .WithMany(t => t.OnCreateRouteStepTypes)
               .HasForeignKey(t => t.OnCreateTaskStatusId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.OnAcceptTaskStatus)
                .WithMany(t => t.OnAcceptRouteStepTypes)
                .HasForeignKey(t => t.OnAcceptTaskStatusId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.OnRejectTaskStatus)
                .WithMany(t => t.OnRejectRouteStepTypes)
                .HasForeignKey(t => t.OnRejectTaskStatusId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(t => t.OnInMethodGroup)
                .WithMany(t => t.RouteStepTypesIn)
                .HasForeignKey(t => t.OnInMethodGroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.OnOutMethodGroup)
                .WithMany(t => t.RouteStepTypesOut)
                .HasForeignKey(t => t.OnOutMethodGroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.OnRejectMethodGroup)
                .WithMany(t => t.RouteStepTypesReject)
                .HasForeignKey(t => t.OnRejectMethodGroupId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
