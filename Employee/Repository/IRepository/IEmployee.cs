using EmployeeManagentWebApplication.Models;

namespace EmployeeManagentWebApplication.Repository.IRepository
{
    public interface IEmployee
    {
        ClientModel CreateClient(ClientModel client);
        ClientModel UpdateClient(ClientModel client,int id);
        EmployeeModel CreateEmployee(EmployeeModel employee);
       
    }
}
