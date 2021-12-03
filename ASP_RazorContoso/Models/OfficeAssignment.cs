using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_RazorContoso.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int LecturerID { get; set; }
        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public Lecturer Lecturer { get; set; }
    }
}
