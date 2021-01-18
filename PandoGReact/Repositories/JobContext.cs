using Bogus;
using Bogus.Extensions;
using Microsoft.EntityFrameworkCore;
using PandoGReact.Models;
using System;

namespace PandoGReact.Repositories
{
    public class JobContext : DbContext
    {

        public JobContext(DbContextOptions<JobContext> options) : base(options)
        {

        }
        public DbSet<JobLine> JobLines { get; set; }
        public DbSet<ViewLine> ViewLines { get; set; }

        public DbSet<JobStat> JobsStats { get; set; }
        public DbSet<ViewStat> ViewStats { get; set; }
        public DbSet<PredictionStat> PredictionStats { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedStatistics(modelBuilder);
            SeedRows(modelBuilder);

         }





        private void SeedRows(ModelBuilder modelBuilder)
        {

            var id = 1;
            DateTime date = new DateTime(2020, 4, 30);
            var stockJobs = new Faker<JobLine>()
                .RuleFor(m => m.Id, f => id++)
                .RuleFor(m => m.DateOpen, f => date.AddDays(1))
                .RuleFor(m => m.Title, f => f.Lorem.Sentence(3))
                .RuleFor(m => m.DateClose, f => date.AddDays(f.Random.Int(1,5)));// date.AddDays(f.Random.Number())

            // generate 50 jobs
            modelBuilder
                .Entity<JobLine>()
                .HasData(stockJobs.Generate(50));


            id = 1;
            date = new DateTime(2020, 4, 30);
            var stockViews = new Faker<ViewLine>()
                .RuleFor(m => m.Id, f => id++)
                .RuleFor(m => m.JobId, f => f.Random.Int(1, 50))
                .RuleFor(m => m.Date, f => date.AddDays(f.Random.Int(0, 2)));

            modelBuilder
                .Entity<ViewLine>()
                .HasData(stockViews.Generate(150));


            //id = 1;
            //date = new DateTime(2020, 4, 30);
            //var stockPrediction = new Faker<PredictionStat>()
            //    .RuleFor(m => m.Id, f => id++)
            //    .RuleFor(m => m.Date, f => date.AddDays(1))
            //    .RuleFor(m => m.Count, f => f.Random.Int(100, 1500));

            //modelBuilder
            //    .Entity<PredictionStat>()
            //    .HasData(stockPrediction.Generate(150));


        }



        private void SeedStatistics(ModelBuilder modelBuilder)
        {
            DateTime date = new DateTime(2020, 4, 30);
            Random randomJobs = new Random();
            Random randomViews = new Random();

            int countJobs = 0;
            int countViews = 0;
            int countPrediction = 0;
            for (int i = 1; i <= 35; i++)
            {
                date = date.AddDays(1);
                int addedJobs = randomJobs.Next(-3, 9);
                countJobs += addedJobs;
                countViews = countJobs * 10;
                countPrediction = (int)Math.Floor(countViews * 1.1);

                modelBuilder.Entity<JobStat>().HasData(
                    new JobStat { Id = i, Date = date, Count = countJobs / 2 });

                modelBuilder.Entity<ViewStat>().HasData(
                    new ViewStat { Id = i, Date = date, Count = countViews });
                modelBuilder.Entity<PredictionStat>().HasData(
                     new PredictionStat { Id = i, Date = date, Count = countPrediction });
            }
        }

    }
}


//private DateTime? GetRandomCloseDate(DateTime openDate)
//{
//    Random randomOpenDays = new Random();
//    int daysOpen = randomOpenDays.Next(0, 5);
//    if (daysOpen==0) return null;
//    else return openDate.AddDays(daysOpen);

//}