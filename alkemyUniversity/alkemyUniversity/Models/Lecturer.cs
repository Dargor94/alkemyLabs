using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace alkemyUniversity.Models
{
    [Table("lecturer")]
    public class Lecturer : Employee
    {
        [Key]
        [Column(name: "lecturer_id")]
        public long LecturerId { get; set; }
        [Column(name: "is_active")]
        public bool IsActive { get; set; }

        public virtual Course Course { get; set; }

    }
}