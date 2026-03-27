using BuilderCompany.Models;
using Microsoft.EntityFrameworkCore;

namespace BuilderCompany.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 1, Title = "Будівництво котеджів", Description = "Будуємо сучасні та надійні будинки під ключ.", IconClass = "🏠" },
                new Service { Id = 2, Title = "Ремонт під ключ", Description = "Виконуємо всі види внутрішніх оздоблювальних робіт.", IconClass = "🛠️" },
                new Service { Id = 3, Title = "Проектування", Description = "Створюємо індивідуальні архітектурні проекти.", IconClass = "📐" }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Name = "ЖК 'Морський'", Location = "м. Одеса", Description = "Елітний житловий комплекс біля моря.", YearCompleted = 2023, ImageUrl = "https://images.unsplash.com/photo-1545324418-cc1a3fa10c00?w=500" },
                new Project { Id = 2, Name = "Котедж 'Лісовий'", Location = "Одеська область", Description = "Екологічний будинок в лісовій зоні.", YearCompleted = 2024, ImageUrl = "https://images.unsplash.com/photo-1512917774080-9991f1c4c750?w=500" }
            );
        }
    }
}