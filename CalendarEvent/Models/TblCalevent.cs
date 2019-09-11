using System;
using System.Collections.Generic;

namespace CalendarEvent.Models
{
    public partial class TblCalevent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Color { get; set; }
        public DateTime? StatsAt { get; set; }
        public DateTime? EndsAt { get; set; }
    }
}
