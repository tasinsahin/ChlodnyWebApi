using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
	public class Employee
	{
		public int EmployeeId { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string Title { get; set; }
		public Nullable<int> ReportsTo { get; set; }
		public Nullable<System.DateTime> BirthDate { get; set; }
		public Nullable<System.DateTime> HireDate { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public string PostalCode { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
		public string Email { get; set; }
	}
}

