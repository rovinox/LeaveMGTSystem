using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveMGTSystem.Models.LeaveTypes;

namespace LeaveMGTSystem.Services
{
    public interface ILeaveTypesService
    {
         Task<bool> CheckIfLeaveTypeNameExists(string name);
        Task<bool> CheckIfLeaveTypeNameExistsForEdit(LeaveTypeEditVM leaveTypeEdit);
        Task Create(LeaveTypeCreateVM model);
        Task Edit(LeaveTypeEditVM model);
        Task<T?> Get<T>(int id) where T : class;
        Task<List<LeaveTypeReadOnlyVM>> GetAll();
        bool LeaveTypeExists(int id);
        Task Remove(int id);
    }
}