using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManagementApp.Models
{
	public class Contact
	{
		public int ContactId { get; set; }

		[Required(ErrorMessage = "Введите имя")]
		[Display(Name = "Имя")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Введите отчество")]
		[Display(Name = "Отчество")]
		public string MiddleName { get; set; }

		[Required(ErrorMessage = "Введите фамилию")]
		[Display(Name = "Фамилия")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Введите адрес электронной почты")]
		[EmailAddress(ErrorMessage = "Некорректный адрес")]
		[Display(Name = "Электронная почта")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Укажите номер телефона")]
		[RegularExpression(@"\+\d \(\d{3}\) \d{3}\-\d{4}", ErrorMessage = "Номер введен неверно")]
		[Display(Name = "Номер телефона")]
		[DataType(DataType.PhoneNumber)]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "Укажите организацию")]
		[Display(Name = "Организация")]
		public int ClientId { get; set; }
		[Display(Name = "Организация")]
		public Client Client { get; set; }

		[Display(Name = "Подразделение")]
		public int? Departmentid { get; set; }
		[Display(Name = "Подразделение")]
		public Department Department { get; set; }

		[Display(Name = "Должность")]
		public int? PositionId { get; set; }
		[Display(Name = "Должность")]
		public Position Position { get; set; }

		[Display(Name = "ФИО")]
		public string FullName
		{
			get { return $"{LastName} {FirstName} {MiddleName}"; }
		}
	}
}
