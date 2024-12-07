using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GE = GlobalEntity;

namespace DataAccessLayer.Interfaces
{
    public interface IEmployeeDA
    {
       Task<List<GE::Employee>> GetEmployee();
        Task<GE::Employee> GetEmployeebycode(int code);
        Task<string> Save(GE::Employee employee);
        Task<string> RemoveEmployee(int code);

    }
}
