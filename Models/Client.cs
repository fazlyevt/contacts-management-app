using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManagementApp.Models
{
	public class Client
	{
		public int ClientId { get; set; }

		[Required(ErrorMessage = "Введите название организации")]
		[Display(Name = "Организация")]
		public string Name { get; set; }

		public List<Contact> Contacts { get; set; }
	}
}
