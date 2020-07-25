using Paycompute.Entity;
using Paycompute.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Employee newEmployee)
        {
            await _context.AddAsync(newEmployee);
            await _context.SaveChangesAsync();
        }

        public async Task DelectAsync(int Id)
        {
            var employee = GetById(Id);
            _context.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Employee> GetAll() => _context.Employees;
        
        //arrow function
        public Employee GetById(int employeeId) => _context.Employees.Where(e => e.Id == employeeId).FirstOrDefault();
        

        public decimal StudentLoanRepaymentAmount(int Id, decimal totalAmount)
        {
            throw new NotImplementedException();
        }

        public decimal UnionFees(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Employee employee)
        {
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int Id)
        {
            var employee = GetById(Id);
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }
    }
}
