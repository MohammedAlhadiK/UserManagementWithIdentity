using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UserManagementWithIdentity.Enums;

namespace UserManagementWithIdentity.Models
{
    [Table(name: "Task", Schema = "tsk")]
    public class MyTask
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Task Name")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Task Owner")]
        public string Owner { get; set; } = "Owner";
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Task Description")]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Task Status")]
        public Tsk_Status? Status { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Task Date")]
        public DateTime? TaskDate { get; set; }

        [DataType(DataType.Time)]
        [Required]
        [Display(Name = "Time From")]
        public DateTime? TaskTimeFrom { get; set; }
        [DataType(DataType.Time)]
        [Required]
        [Display(Name = "Time To")]
        public DateTime? TaskTimeTo { get; set; }
        [Required]
        public string CreatorID { get; set; } = "Test";

    }
}
