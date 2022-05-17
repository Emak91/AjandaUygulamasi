using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gorevYoneticisi.Model
{
    public class ListEventsDTO
    {
        public int Id { get; set; }
        public string title { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public string allDay { get; set; }
        public string color { get; set; }
        public string textColor { get; set; }
    }
}
