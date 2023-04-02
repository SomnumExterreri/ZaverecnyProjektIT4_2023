using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaverecnaPrace
{
    internal class WorkHours
    {
        public WorkHours(int id, int personalNumber, int contactId, int workTypeStyleId, int hours)
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
        public int WorkTypeStyleId { get; set; }
        public int Hours { get; set; }
    }
}
