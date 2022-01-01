using AuthenticationExample.Entities;

namespace AuthenticationExample.IServices
{
    public interface IDatabaseService
    {
        List<Employee> GetAll();
    }
}
