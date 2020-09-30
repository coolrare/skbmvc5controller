using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Controllers
{
    public class CourseEditViewModel
    {
        public int CourseID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
    }
}