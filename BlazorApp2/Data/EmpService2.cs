using BlazorApp2.Models;

namespace BlazorApp2.Data
{
    public class EmpService2
    {
        private readonly EmployeeDBContext _dbContext;


        public EmpService2(EmployeeDBContext _dbContext)
        {
            this._dbContext = _dbContext;
        }

        public async Task<List<AllEmployeeResult>> GetAllEmployeesAsync(int? value)
        {
            return await _dbContext.Procedures.AllEmployeeAsync(value);
        }

        public async Task<int> DeleteEmployeeAsync(int? Id, int? value1)
        {
            return await _dbContext.Procedures.DelectEmployee1Async(Id, value1);
        }

        public async Task<int> InsertEmployeeAsync(string Name, string Email, string Phone, string Gender, string Skill, string Address)
        {
            return await _dbContext.Procedures.InsertEmployeeAsync(Name, Email, Phone, Gender, Skill, Address);
        }

        public async Task<List<SelectById1Result>> GetEmployeeByIdAsync(int? value)
        {
            return await _dbContext.Procedures.SelectById1Async(value);
        }

        public async Task<int> UpdateEmployeeAsync(int? Id, string Name, string Email, string Phone, string Address, string Skill)
        {
            return await _dbContext.Procedures.UpdateEmployeeAsync(Id, Name, Email, Phone, Address, Skill);
        }
    }
}
