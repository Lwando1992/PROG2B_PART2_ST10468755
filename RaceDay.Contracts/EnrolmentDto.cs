using System;
using System.Collections.Generic;
using System.Text;

namespace RaceDay.Contracts
{
    public class EnrolmentDto
    {
        public int ParticipantId { get; set; }
        public int EventId { get; set; }
        public int CategoryId { get; set; }
    }
}
