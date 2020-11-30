using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMetrodata.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string StudentGender { get; set; }
        public string ClassLevel { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}