using AuthenticationExample.DatabaseContext;
using AuthenticationExample.Entities;
using AuthenticationExample.IServices;

namespace AuthenticationExample.Services
{
    public class DatabaseService :IDatabaseService
    {
        public List<Employee> GetAll()
        {
            var employees = new List<Employee>();
            using (var db= new EmployeeDBContext())
            {
                var query=(from s in db.Employees
                           select  new Employee
                           {
                               
                               EmployeeId=s.EmployeeId,
                               EmployeeName=s.EmployeeName,
                               Department=s.Department,
                               DateOfJoining=s.DateOfJoining,
                               PhotoFileName=s.PhotoFileName,
                               Password=s.Password,
                           });
                employees=query.ToList();
            }
            return employees;
        }

    }
}
