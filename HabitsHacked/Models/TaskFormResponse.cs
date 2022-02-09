using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HabitsHacked.Models
{
    public class TaskFormResponse
    {
        [Key]
        [Required]
        public int TaskID { get; set; }
        [Required]
        public string TaskName { get; set; }
        public int DueDate { get; set; }
        [Required]
        public string Quadrant { get; set; }
        public string TaskCategory { get; set; }
        public bool Completed { get; set; }
    }
}
