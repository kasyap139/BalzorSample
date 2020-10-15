using System.Collections.Generic;
using System.Linq;
using LeicaInstallation.Shared;

namespace LeicaInstallationDB.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Environments> GetAllEmployees()
        {
            return _appDbContext.Environments;
        }

        public Environments GetEmployeeById(int employeeId)
        {
            return _appDbContext.Environments.FirstOrDefault(c => c.EmployeeId == employeeId);
        }

        public Environments AddEmployee(Environments employee)
        {
            var addedEntity = _appDbContext.Environments.Add(employee);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public Environments UpdateEmployee(Environments employee)
        {
            var foundEmployee = _appDbContext.Environments.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);

            if (foundEmployee != null)
            {
                foundEmployee.CountryId = employee.CountryId;
                //foundEmployee.MaritalStatus = employee.MaritalStatus;
                foundEmployee.BirthDate = employee.BirthDate;
                foundEmployee.City = employee.City;
                foundEmployee.Email = employee.Email;
                foundEmployee.FirstName = employee.FirstName;
                foundEmployee.LastName = employee.LastName;
                //foundEmployee.Gender = employee.Gender;
                foundEmployee.PhoneNumber = employee.PhoneNumber;
                foundEmployee.Smoker = employee.Smoker;
                foundEmployee.Street = employee.Street;
                foundEmployee.Zip = employee.Zip;
                foundEmployee.JobCategoryId = employee.JobCategoryId;
                foundEmployee.Comment = employee.Comment;
                foundEmployee.ExitDate = employee.ExitDate;
                foundEmployee.JoinedDate = employee.JoinedDate;

                _appDbContext.SaveChanges();

                return foundEmployee;
            }

            return null;
        }

        public void DeleteEmployee(int employeeId)
        {
            var foundEmployee = _appDbContext.Environments.FirstOrDefault(e => e.EmployeeId == employeeId);
            if (foundEmployee == null) return;

            _appDbContext.Environments.Remove(foundEmployee);
            _appDbContext.SaveChanges();
        }
    }
}
