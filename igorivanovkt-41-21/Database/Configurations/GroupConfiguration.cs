using igorivanovkt_41_21.Database.Helpers;
using igorivanovkt_41_21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace igorivanovkt_41_21.Database.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        private const string TableName = "cd_group";

        public void Configure(EntityTypeBuilder<Group> builder)
        {
            //первичный ключ
            builder
                .HasKey(p => p.GroupId)
                .HasName($"pk_{TableName}_group_id");

            //автоинкремент pk
            builder.Property(p => p.GroupId)
               .ValueGeneratedOnAdd();

            //названия столбцов
            builder.Property(p => p.GroupId)
                .HasColumnName("group_id")
                .HasComment("Идентификатор записи группы");

            builder.Property(p => p.GroupName)
                .IsRequired()
                .HasColumnName("c_group_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название группы");

            //название таблицы
            builder.ToTable(TableName);
        }
    }
}
