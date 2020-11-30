using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMetrodata.Models
{
    public class Inventory
    {
        [Key]
        public int LendingID { get; set; }
        public int BookID { get; set; }
        public int StudentID { get; set; }
        public DateTime LendDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual Student Student { get; set; }
    }
}