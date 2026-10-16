using System;
using System.Collections.Generic;
using System.Text;

namespace RaceDay.Contracts
{
    public class EventDto
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
    }
}
