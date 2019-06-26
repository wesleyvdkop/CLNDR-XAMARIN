using System;
using System.Collections.Generic;

namespace clndr.Api.Models
{
    enum EventTypes
    {
        Birthday = 1,
        DateOfService = 2,
        OutOfOffice = 3,
        Holiday = 4,
        NationalHoliday = 5,
        Custom = 6
    }

    public class CalendarEventDto
    {
        public string Id { get; set; }
        public int Type { get; set; }
        public string EmployeeId { get; set; }
        public string OfficeId { get; set; }
        public object Data { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Day { get; set; }
    }
}
