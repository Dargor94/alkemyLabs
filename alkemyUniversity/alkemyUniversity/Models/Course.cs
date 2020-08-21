using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace alkemyUniversity.Models
{
    [Table("course")]
    public class Course
    {
        [Key]
        [Column(name: "course_id")]
        public long CourseId { get; set; }
        public TimeSpan[] Schedules { get; set; } = new TimeSpan[2];
        [Column(name: "max_student_quota")]
        public short MaxStudentQuota { get; set; }


        [Column(name: "lecturer_id")]
        public long LecturerId { get; private set; }
        [Required]
        public virtual Lecturer Lecturer { get; set; }


        [Column(name: "student_id")]
        public long StudentId { get; private set; }
        [Required]
        public virtual ICollection<Student> Students { get; set; }

    }
}