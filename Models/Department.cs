using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManagementApp.Models
{
	public class Department
	{
		public int DepartmentId { get; set; }

		[Required(ErrorMessage = "Введите название подразделения")]
		[Display(Name = "Подразделение")]
		public string Name { get; set; }
	}
}
