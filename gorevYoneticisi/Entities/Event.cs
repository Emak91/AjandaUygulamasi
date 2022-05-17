using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gorevYoneticisi.Entities
{
    public class Event
    {
        [Key]
        public int id { get; set; }

        [Column (TypeName ="nvarchar(100)")]
        public string tittle { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }

        [Column(TypeName ="nvarchar(10)")]
        public string color { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string textColor { get; set; }
    }
}
