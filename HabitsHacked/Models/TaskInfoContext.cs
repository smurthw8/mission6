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
    }
}
