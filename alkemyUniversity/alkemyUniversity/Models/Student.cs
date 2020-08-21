using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace alkemyUniversity.Models
{
    [Table("student")]
    public class Student : Person
    {
        [Key]
        [Column(name: "student_id")]
        public long StudentId { get; set; }
        public long Bundle { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}