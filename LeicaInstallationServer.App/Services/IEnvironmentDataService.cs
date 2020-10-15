using LeicaInstallation.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeicaInstallationServer.App.Services
{
    public interface IEnvironmentDataService
    {
        Task<IEnumerable<Environments>> GetAllEmployees();

        Task<Environments> GetEmployeeDetails(int employeeId);

        Task<Environments> AddEmployee(Environments employee);

        Task UpdateEmployee(Environments employee);

        Task DeleteEmployee(int employeeId);
    }
}
