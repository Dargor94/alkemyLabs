using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace alkemyUniversity.Models
{
    [Table("person")]
    public abstract class Person
    {
        [Key]
        [Column(name: "person_id")]
        public long PersonId { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        [Column(name: "first_name")]
        public string FirstName { get; set; }
        [Column(name: "last_name")]
        public string LastName { get; set; }

    }
}