using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class DictionaryDivizionOZMMap : IEntityTypeConfiguration<DictionaryDivizionOZM>
    {
        public void Configure(EntityTypeBuilder<DictionaryDivizionOZM> builder)
        {
            builder.HasKey(t => t.DictionaryDivizionOZMId);

            builder.ToTable("Dictionary_DivizionOZM");

            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Code).HasColumnName("Code");
            builder.Property(t => t.EconomistId).HasColumnName("EconomistId");

            builder.Property(t => t.Economist).IsRequired();
            builder.HasOne(t => t.Economist)
                .WithMany(t => t.Economists)
                .HasForeignKey(t => t.EconomistId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}