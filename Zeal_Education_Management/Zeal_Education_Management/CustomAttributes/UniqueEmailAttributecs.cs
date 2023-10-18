
using System.ComponentModel.DataAnnotations;

using System;
using System.Linq;
using Zeal_Education_Management.Models;

namespace Zeal_Education_Management.CustomAttributes
	{
		public class UniqueEmailAttributecs
		{

			[AttributeUsage(AttributeTargets.Property)]
			public class UniqueEmailAttribute : ValidationAttribute
			{
				protected override ValidationResult IsValid(object value, ValidationContext validationContext)
				{
					var dbContext = validationContext.GetRequiredService<ZealDBContext>();

					if (dbContext.Users.Any(u => u.Email == value.ToString()))
					{
						return new ValidationResult("Email is already in use.");
					}

					return ValidationResult.Success;
				}
			}


		}
	}




