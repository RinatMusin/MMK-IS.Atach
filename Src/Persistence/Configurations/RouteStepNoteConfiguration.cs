using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class RouteStepNoteMap : IEntityTypeConfiguration<RouteStepNote>
    {
        public void Configure(EntityTypeBuilder<RouteStepNote> builder)
        {
            builder.HasKey(t => t.RouteStepNoteId);

            builder.ToTable("RouteStepNote");

            builder.Property(t => t.RouteStepNoteId).HasColumnName("RouteStepNoteId");
            builder.Property(t => t.NoteId).HasColumnName("NoteId");
            builder.Property(t => t.RouteStepId).HasColumnName("RouteStepId");

            builder.Property(t => t.RouteStep).IsRequired();
            builder.HasOne(t => t.RouteStep)
                .WithMany(t => t.RouteStepNotes)
                .HasForeignKey(t => t.RouteStepId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.SendingForRevision).IsRequired();
            builder.HasOne(t => t.SendingForRevision)
                .WithMany(t => t.RouteStepNotes)
                .HasForeignKey(t => t.NoteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
