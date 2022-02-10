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

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }
        [Required]
        public string Quadrant { get; set; }
        public bool Completed { get; set; }

        //build foriegn key relationship
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        
    }
}
