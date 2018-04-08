using System;
namespace ProjetIncident.Core
{
    public class Member
    {
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public DateTime DateTime { get; set; }

		public Member(string firstName, string lastName, DateTime dateTime)
		{
			FirstName = firstName;
			LastName = lastName;
			DateTime = dateTime;
		}
	}
}
