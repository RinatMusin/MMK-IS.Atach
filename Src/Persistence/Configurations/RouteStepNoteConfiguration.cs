using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class RouteStepNoteConfiguration : IEntityTypeConfiguration<RouteStepNote>
    {
        public void Configure(EntityTypeBuilder<RouteStepNote> builder)
        {
            builder.HasKey(t => t.RouteStepNoteId);

            builder.ToTable("RouteStepNote");

            builder.Property(t => t.RouteStepNoteId).HasColumnName("RouteStepNoteId");
            builder.Property(t => t.NoteId).HasColumnName("NoteId");
            builder.Property(t => t.RouteStepId).HasColumnName("RouteStepId");

            builder.HasOne(t => t.RouteStep).WithOne().IsRequired();
            builder.HasOne(t => t.RouteStep)
                .WithMany(t => t.RouteStepNotes)
                .HasForeignKey(t => t.RouteStepId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.SendingForRevision).WithOne().IsRequired();
            builder.HasOne(t => t.SendingForRevision)
                .WithMany(t => t.RouteStepNotes)
                .HasForeignKey(t => t.NoteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
