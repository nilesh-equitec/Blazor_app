using System.Collections.Generic;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Data
{
    public class EmpService1
    {
        private readonly EmployeeDBContext _dbContext;

        public EmpService1(EmployeeDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Emp> GetTodoItems()
        {
            return _dbContext.Emps.ToList();
        }

        public void AddTodoItem(Emp todoItem)
        {
            _dbContext.Emps.Add(todoItem);
            _dbContext.SaveChanges();
        }
    }
}
