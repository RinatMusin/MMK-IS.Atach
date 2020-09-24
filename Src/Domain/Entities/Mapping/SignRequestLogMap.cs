﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{

    public class SignRequestLogMap : IEntityTypeConfiguration<SignRequestLog>
    {
        public void Configure(EntityTypeBuilder<SignRequestLog> builder)
        {
            builder.HasKey(t => t.LogId);

            builder.ToTable("SignRequestLog");

            builder.Property(t => t.RequestURL).HasColumnName("RequestURL").HasColumnType("varchar");
            builder.Property(t => t.Authorization).HasColumnName("Authorization").HasColumnType("varchar");
            builder.Property(t => t.RequestContentType).HasColumnName("RequestContentType").HasColumnType("varchar");
            builder.Property(t => t.RequestContent).HasColumnName("RequestContent");
            builder.Property(t => t.RequestQuery).HasColumnName("RequestQuery");
            builder.Property(t => t.RequestMethod).HasColumnName("RequestMethod").HasColumnType("varchar");
            builder.Property(t => t.ResponseContent).HasColumnName("ResponseContent");
            builder.Property(t => t.ResponseContentType).HasColumnName("ResponseContentType").HasColumnType("varchar");
            builder.Property(t => t.ResponseStatusCode).HasColumnName("ResponseStatusCode").HasColumnType("varchar");
            builder.Property(t => t.ResponseTimestamp).HasColumnName("CreationDate");
            builder.Property(t => t.RequestTimestamp).HasColumnName("LastUpdateDate");
            builder.Property(t => t.DocumentId).HasColumnName("DocumentId").IsOptional();
            builder.Property(t => t.UniqueTransactionId).HasColumnName("UniqueTransactionId").IsOptional();
        }

    }
}



