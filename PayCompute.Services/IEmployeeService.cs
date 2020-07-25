using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Services
{
    public interface IEmployeeService
    {
        Task CreateAsync(Employee newEmployee);

        Employee GetById(int employeeId);

        Task UpdateAsync(Employee employee);

        Task UpdateAsync(int Id);

        Task DelectAsync(int Id);
        decimal UnionFees(int Id);
        decimal StudentLoanRepaymentAmount(int Id, decimal totalAmount);

        IEnumerable<Employee> GetAll();
    }
}
