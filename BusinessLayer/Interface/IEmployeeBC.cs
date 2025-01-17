﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GE = GlobalEntity;

namespace BusinessLayer.Interface
{
    public interface IEmployeeBC
    {
       Task<List<GE::Employee>> GetEmployees();
        Task<GE::Employee> GetEmployeebycode(int code);
        Task<string> Save(GE::Employee employee);
        Task<string> RemoveEmployee(int code);
    }
}
