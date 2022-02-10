using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitsHacked.Models
{
    public class TaskInfoContext : DbContext
    {
        //constructor
        public TaskInfoContext (DbContextOptions<TaskInfoContext> options) : base (options)
        {
            // Leave blank for now
        }

        public DbSet<TaskFormResponse> TaskResponses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected void OnModelCreate(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Home" },
                new Category { CategoryID = 2, CategoryName = "School" },
                new Category { CategoryID = 3, CategoryName = "Work" },
                new Category { CategoryID = 4, CategoryName = "Church" }
            );

            mb.Entity<TaskFormResponse>().HasData(
                new TaskFormResponse
                {
                    TaskID = 1,
                    TaskName = "Mission 6",
                    DueDate = DateTime.ParseExact("2022-02-09", "yyyy-MM-dd", null),
                    Quadrant = "Quadrant 1",
                    CategoryID = 2,
                    Completed = true
                },
                new TaskFormResponse
                {
                    TaskID = 2,
                    TaskName = "Feed the Dog",
                    DueDate = DateTime.ParseExact("2022-02-10", "yyyy-MM-dd", null),
                    Quadrant = "Quadrant 2",
                    CategoryID = 1,
                    Completed = false
                },
                new TaskFormResponse
                {
                    TaskID = 3,
                    TaskName = "Call Stake President",
                    DueDate = DateTime.ParseExact("2022-02-12", "yyyy-MM-dd", null),
                    Quadrant = "Quadrant 3",
                    CategoryID = 4,
                    Completed = false
                },
                new TaskFormResponse
                {
                    TaskID = 4,
                    TaskName = "Watch New Girl",
                    DueDate = DateTime.ParseExact("2022-02-10", "yyyy-MM-dd", null),
                    Quadrant = "Quadrant 4",
                    CategoryID = 1,
                    Completed = true
                },
                new TaskFormResponse
                {
                    TaskID = 4,
                    TaskName = "Weekly Work Meeting",
                    DueDate = DateTime.ParseExact("2022-02-11", "yyyy-MM-dd", null),
                    Quadrant = "Quadrant 2",
                    CategoryID = 3,
                    Completed = true
                }
            );
        }
    }
}
