using EmployeeManagentWebApplication.Data;
using EmployeeManagentWebApplication.Models;
using EmployeeManagentWebApplication.Repository.IRepository;

namespace EmployeeManagentWebApplication.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly EmployeeDbContext _emp;
        public EmployeeRepository(EmployeeDbContext emp)
        {
            _emp = emp;
        }
        public ClientModel CreateClient(ClientModel client)
        {
            _emp.Clients.Add(client);
            _emp.SaveChanges();
            return (client);
        }

        public EmployeeModel CreateEmployee(EmployeeModel employee)
        {
            _emp.Employee.Add(employee);
            _emp.SaveChanges();
            return (employee);
        }

        public ClientModel UpdateClient(ClientModel client, int id)
        {
            var client1 = _emp.Clients.FirstOrDefault(x => x.ClientId == id);
            if (client1 != null)
            {
                client1.ClientId = id;
                client1.ClientName = client.ClientName;
                client1.ClientType = client.ClientType;
                client1.ClientAddress = client.ClientAddress;
            };
            _emp.Clients.Update(client1);
            _emp.SaveChanges();
            return (client1);
        }
    }
}
