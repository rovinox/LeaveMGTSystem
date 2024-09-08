using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveMGTSystem.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM 
    {
          public string Name { get; set; } = string.Empty;
        
        [Display(Name = "Maximum Allocation of Days")] 
        public int NumberOfDays { get; set; }
    }
}