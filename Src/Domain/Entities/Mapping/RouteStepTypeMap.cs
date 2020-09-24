using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class RouteStepTypeMap : IEntityTypeConfiguration<RouteStepType>
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


            builder.HasOptional(t => t.OnCreateTaskStatus)
               .WithMany(t => t.OnCreateRouteStepTypes)
               .HasForeignKey(t => t.OnCreateTaskStatusId)
               .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.OnAcceptTaskStatus)
                .WithMany(t => t.OnAcceptRouteStepTypes)
                .HasForeignKey(t => t.OnAcceptTaskStatusId)
                .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.OnRejectTaskStatus)
                .WithMany(t => t.OnRejectRouteStepTypes)
                .HasForeignKey(t => t.OnRejectTaskStatusId)
                .WillCascadeOnDelete(false);


            builder.HasOptional(t => t.OnInMethodGroup)
                .WithMany(t => t.RouteStepTypesIn)
                .HasForeignKey(t => t.OnInMethodGroupId)
                .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.OnOutMethodGroup)
                .WithMany(t => t.RouteStepTypesOut)
                .HasForeignKey(t => t.OnOutMethodGroupId)
                .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.OnRejectMethodGroup)
                .WithMany(t => t.RouteStepTypesReject)
                .HasForeignKey(t => t.OnRejectMethodGroupId)
                .WillCascadeOnDelete(false);
        }
    }
}
