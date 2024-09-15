using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveMGTSystem.Models.LeaveTypes
{
    public class LeaveType :BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int NumberOfDays { get; set; }
    }
}