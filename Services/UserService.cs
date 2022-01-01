using AuthenticationExample.Entities;
using AuthenticationExample.IServices;


namespace AuthenticationExample.Services
{
    public class UserService : IUserService
    {

        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        IDatabaseService _databaseService;
        public UserService(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<Employee> Authenticate(string username, string password)
        {
            // wrapped in "await Task.Run" to mimic fetching user from a db
            var data = new List<Employee>();
            data = _databaseService.GetAll();
            var user = await Task.Run(() => data.FirstOrDefault(x => x.EmployeeName==username && x.Password==password));

            // on auth fail: null is returned because user is not found
            // on auth success: user object is returned
            return user;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            // wrapped in "await Task.Run" to mimic fetching users from a db
            return await Task.Run(() => _databaseService.GetAll());
        }
    }
}
