using Microsoft.EntityFrameworkCore;
using week13_odev5.Models;

namespace week13_odev5.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<FitnessClass> FitnessClasses { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<FitnessClass>()
            .Property(f => f.Fee)
            .HasPrecision(10, 2);

        modelBuilder.Entity<Trainer>().HasData(
            new Trainer
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Yılmaz",
                Specialization = "Fitness",
                ExperienceYears = 8,
                PhotoUrl = "/images/ahmet.jpg"
            },
            new Trainer
            {
                Id = 2,
                FirstName = "Ayşe",
                LastName = "Demir",
                Specialization = "Pilates",
                ExperienceYears = 6,
                PhotoUrl = "/images/ayse.jpg"
            },
            new Trainer
            {
                Id = 3,
                FirstName = "Mehmet",
                LastName = "Kaya",
                Specialization = "Yoga",
                ExperienceYears = 5,
                PhotoUrl = "/images/mehmet.jpg"
            },
            new Trainer
            {
                Id = 4,
                FirstName = "Zeynep",
                LastName = "Çelik",
                Specialization = "Zumba",
                ExperienceYears = 7,
                PhotoUrl = "/images/zeynep.jpg"
            }
        );
        modelBuilder.Entity<FitnessClass>().HasData(
        new FitnessClass
        {
            Id = 1,
            ClassName = "Fitness Başlangıç",
            Description = "Yeni başlayanlar için temel fitness eğitimi",
            DurationMinutes = 60,
            Capacity = 15,
            Fee = 250.00m,
            IsActive = true,
            TrainerId = 1
        },
        new FitnessClass
        {
            Id = 2,
            ClassName = "İleri Seviye Fitness",
            Description = "Deneyimli katılımcılar için kuvvet antrenmanı",
            DurationMinutes = 75,
            Capacity = 12,
            Fee = 350.00m,
            IsActive = true,
            TrainerId = 1
        },
        new FitnessClass
        {
            Id = 3,
            ClassName = "Fonksiyonel Antrenman",
            Description = "Dayanıklılık ve koordinasyon çalışmaları",
            DurationMinutes = 50,
            Capacity = 15,
            Fee = 300.00m,
            IsActive = true,
            TrainerId = 1
        },
        new FitnessClass
        {
            Id = 4,
            ClassName = "Mat Pilates",
            Description = "Mat üzerinde temel pilates hareketleri",
            DurationMinutes = 50,
            Capacity = 12,
            Fee = 280.00m,
            IsActive = true,
            TrainerId = 2
        },
        new FitnessClass
        {
            Id = 5,
            ClassName = "Reformer Pilates",
            Description = "Reformer ekipmanlarıyla pilates eğitimi",
            DurationMinutes = 55,
            Capacity = 8,
            Fee = 450.00m,
            IsActive = true,
            TrainerId = 2
        },
        new FitnessClass
        {
            Id = 6,
            ClassName = "Başlangıç Yoga",
            Description = "Temel yoga duruşları ve nefes egzersizleri",
            DurationMinutes = 60,
            Capacity = 15,
            Fee = 250.00m,
            IsActive = true,
            TrainerId = 3
        },
        new FitnessClass
        {
            Id = 7,
            ClassName = "Vinyasa Yoga",
            Description = "Akıcı yoga hareketleri ve esneklik çalışmaları",
            DurationMinutes = 70,
            Capacity = 12,
            Fee = 320.00m,
            IsActive = true,
            TrainerId = 3
        },
        new FitnessClass
        {
            Id = 8,
            ClassName = "Meditasyon ve Nefes",
            Description = "Rahatlama ve nefes teknikleri",
            DurationMinutes = 45,
            Capacity = 20,
            Fee = 200.00m,
            IsActive = false,
            TrainerId = 3
        },
        new FitnessClass
        {
            Id = 9,
            ClassName = "Zumba",
            Description = "Dans ve kardiyo temelli grup egzersizi",
            DurationMinutes = 60,
            Capacity = 20,
            Fee = 270.00m,
            IsActive = true,
            TrainerId = 4
        },
        new FitnessClass
        {
            Id = 10,
            ClassName = "Zumba Gold",
            Description = "Düşük tempolu dans ve fitness egzersizleri",
            DurationMinutes = 45,
            Capacity = 18,
            Fee = 230.00m,
            IsActive = true,
            TrainerId = 4
        }
    );
    }
}