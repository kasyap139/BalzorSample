using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeicaInstallation.Shared;

namespace LeicaInstallationDB.Api.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Environments> GetAllEmployees();
        Environments GetEmployeeById(int employeeId);
        Environments AddEmployee(Environments employee);
        Environments UpdateEmployee(Environments employee);
        void DeleteEmployee(int employeeId);
    }
}
