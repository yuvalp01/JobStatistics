using Bogus;
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
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobView> JobViews { get; set; }
        public DbSet<JobViewPrediction> jobViewPredictions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
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
                countPrediction = (int) Math.Floor(countViews * 1.1);

                modelBuilder.Entity<Job>().HasData(
                    new Job { Id = i, Date = date, Count = countJobs/2 });

                modelBuilder.Entity<JobView>().HasData(
                    new JobView { Id = i, Date = date, Count = countViews });
                modelBuilder.Entity<JobViewPrediction>().HasData(
                     new JobViewPrediction { Id = i, Date = date, Count = countPrediction });
            }


         }

    }
}