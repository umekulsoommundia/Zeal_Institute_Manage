using System.ComponentModel.DataAnnotations;

namespace Zeal_Education_Management.Models
{
	public enum UserType
	{
		Student = 1,
		Instructor =2
	}
	public class UserModel
	{
		public int Id { get; set; }

		
		public string Email { get; set; }

		public string Password { get; set; }

		public UserType UserType { get; set; }

	}

}
