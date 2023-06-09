﻿using EmployeeManagentWebApplication.Models;
using EmployeeManagentWebApplication.Repository.IRepository;
using EmployeeManagentWebApplication.ServiceLayer.IService;

namespace EmployeeManagentWebApplication.ServiceLayer
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployee _emp;
        public EmployeeService(IEmployee emp) 
        {
            _emp = emp;
        }
        public ClientModel CreateClient(ClientModel client)
        {
            var client1 = new ClientModel()
            {
                ClientName = client.ClientName,
                ClientType = client.ClientType,
                ClientAddress = client.ClientAddress,
            };
          return (_emp.CreateClient(client1));
        }

        public EmployeeModel CreateEmployee(EmployeeModel employee)
        {
            var employee1 = new EmployeeModel()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Phone = employee.Phone,
                Address = employee.Address,
                City = employee.City,
                State = employee.State,
                Designation = employee.Designation,
                TechStack = employee.TechStack,
                ReportingManager = employee.ReportingManager,
                CompanyId = employee.CompanyId
            };
            return(_emp.CreateEmployee(employee1));
        }

        public ClientModel UpdateClient(ClientModel client, int id)
        {
            return (_emp.UpdateClient(client, id));
        }
    }
}
