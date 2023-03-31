using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaverecnaPrace
{
    internal class WorkHours
    {
        public WorkHours(int id, int personalNumber, int contactId, string workTypeStyleId, TimeSpan hours)
        {
            Id = id;
            PersonalNumber = personalNumber;
            ContactId = contactId;
            WorkTypeStyleId = workTypeStyleId;
            Hours = hours;
        }

        public int Id { get; set; }
        public int PersonalNumber { get; set; }
        public int ContactId { get; set; }
        public string WorkTypeStyleId { get; set; }
        public TimeSpan Hours { get; set; }
    }
}
