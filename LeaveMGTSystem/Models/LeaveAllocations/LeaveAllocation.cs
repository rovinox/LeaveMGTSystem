using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveMGTSystem.Models.LeaveTypes;
using LeaveMGTSystem.Models.Periods;

namespace LeaveMGTSystem.Models.LeaveAllocations
{
    public class LeaveAllocation : BaseEntity
    {
        public LeaveType? LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public ApplicationUser? Employee { get; set; }
        public string EmployeeId { get; set; } = string.Empty;

        public Period? Period { get; set; }
        public int PeriodId { get; set; }

        public int Days {  get; set; }
    }
}