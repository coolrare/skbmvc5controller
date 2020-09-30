using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Controllers
{
    public class CourseEditViewModel
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
    }
}