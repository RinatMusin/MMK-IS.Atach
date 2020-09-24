using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    class MethodGroupeMap : IEntityTypeConfiguration<MethodGroupe>
    {
        public void Configure(EntityTypeBuilder<MethodGroupe> builder)
        {
            builder.HasKey(t => t.MethodGroupeId);

            builder.ToTable("Method_Groupe");
        }
    }
}
