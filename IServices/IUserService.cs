using AuthenticationExample.Entities;


namespace AuthenticationExample.IServices
{
    public interface IUserService
    {
        Task<Employee> Authenticate(string username, string password);
        Task<IEnumerable<Employee>> GetAll();
    }
}

