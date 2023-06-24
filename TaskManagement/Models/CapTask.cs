//create task class with properties
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models
{
    public class CapTask
    {
        [Required]
        //add display name attribute on id
        [Display(Name = "Task Id")]
        public int Id { get; set; }

        //add disply name attribute on name
        [Display(Name = "Task Name")]
        //add required attributes on name
        [Required]
        public string TaskName { get; set; }

        //add required attributes on name
        [Required]
        //add display name attribute on description
        [Display(Name = "Task Description")]
        public string TaskDescription { get; set; }

        //add display name attribute on due date
        [Display(Name = "Due Date")]
        public DateTime TaskDueDate { get; set; }

        //add display name attribute on status
        [Display(Name = "Task Status")]
        public string TaskStatus { get; set; }

    }
}