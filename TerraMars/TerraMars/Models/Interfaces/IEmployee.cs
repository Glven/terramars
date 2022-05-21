using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraMars.Data.Entities;


namespace TerraMars.Models.Interfaces
{
	public interface IEmployee
	{
		Task<IList<Employee>> AllEmployees();
		Task CreateEmployee(string Photo, string Fullname, string Post, ushort Experience);
		Task DeleteEmployee(Guid EmployeeId);
		Task EditEmployee(Employee employee);
	}
}
