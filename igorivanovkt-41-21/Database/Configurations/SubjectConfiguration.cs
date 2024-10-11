using igorivanovkt_41_21.Database.Helpers;
using igorivanovkt_41_21.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace igorivanovkt_41_21.Database.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        private const string TableName = "cd_Subject";

        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            //первичный ключ
            builder
                .HasKey(p => p.SubjectId)
                .HasName($"pk_{TableName}_Subject_id");

            //автоинкремент pk
            builder.Property(p => p.SubjectId)
               .ValueGeneratedOnAdd();

            //названия столбцов
            builder.Property(p => p.SubjectId)
                .HasColumnName("Subject_id")
                .HasComment("Идентификатор записи предмета");

            builder.Property(p => p.SubjectName)
                .IsRequired()
                .HasColumnName("c_Subject_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название предмета");
            builder.Property(p => p.GroupId)
               .IsRequired()
               .HasColumnName("f_group_id")
               .HasColumnType(ColumnType.Int)
               .HasComment("Идентификатор группы");

            builder.ToTable(TableName)
                .HasOne(p => p.Group)
                .WithMany()
                .HasForeignKey(p => p.GroupId)
                .HasConstraintName("fk_f_group_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
               .HasIndex(p => p.GroupId, $"idx_{TableName}_fk_f_group_id");

            //название таблицы
            builder.ToTable(TableName);
        }
    }
}