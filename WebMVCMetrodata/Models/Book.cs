using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebMVCMetrodata.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}