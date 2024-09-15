using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveMGTSystem.Models.Periods
{
    public class Period : BaseEntity
    {
         public string Name { get; set; } = string.Empty;
        public DateOnly StartDate { get;set; }
        public DateOnly EndDate { get;set; }
    }
}