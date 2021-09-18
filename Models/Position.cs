using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManagementApp.Models
{
	public class Position
	{
		public int PositionId { get; set; }

		[Required(ErrorMessage = "Введите название должности")]
		[Display(Name = "Должность")]
		public string Name { get; set; }
	}
}
