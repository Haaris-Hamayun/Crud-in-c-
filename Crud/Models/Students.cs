using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class Students { 


        [Key]
    [Display(Name = "Student ID")]
    public int StudentID { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string Name  { get; set; }

        public string Email { get; set; }

        public string Course { get; set; }

        
        [Display(Name = "EnrollementDate")]

        public DateTime EnrollmentDate { get; set; }

    }
}
