using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveMGTSystem.Models.LeaveTypes
{
    public class IndexVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int NumberOfDays { get; set; }
    }
}