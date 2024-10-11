using igorivanovkt_41_21.Database.Configurations;
using igorivanovkt_41_21.Models;
using Microsoft.EntityFrameworkCore;

namespace igorivanovkt_41_21.Database
{
    public class StudentDbContext : DbContext
    {
        //Добавляем таблицы
        DbSet<Student> Students { get; set; }
        DbSet<Group> Groups { get; set; }

        DbSet<Group> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Добавляем конфигурации к таблицам
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());

        }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
    }
}