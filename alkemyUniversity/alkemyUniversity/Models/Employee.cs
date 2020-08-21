using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace alkemyUniversity.Models
{
    [Table("employee")]
    public class Employee : Person
    {
        [Key]
        [Column(name: "employee_id")]
        public long EmployeeId { get; set; }
        [Column(name: "identification_number")]
        public long IdentificationNumber { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        [Column(name: "is_admin")]
        public bool IsAdmin { get; set; }

    }
}