using System;
namespace clndr.Api.Models
{
    public class CalendarCreateDto
    {
        public DateTime StartDay { get; set; }
        public int Type { get; set; }
        public object Data { get; set; }
        public bool Day { get; set; }
    }
}
