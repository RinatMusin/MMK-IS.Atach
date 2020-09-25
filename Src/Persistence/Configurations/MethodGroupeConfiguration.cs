using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
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
