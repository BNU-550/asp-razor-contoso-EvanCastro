using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASP_RazorContoso.Models
    {
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }
        public string CourseCodep { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }




        //Navigation Properties
        public Department Department { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Lecturer> Lecturers { get; set; }
    }

}
