using System.ComponentModel.DataAnnotations;

namespace Zeal_Education_Management.Models
{
	public class CourseModel
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Course title is required")]
		public string Title { get; set; }

		[Required(ErrorMessage = "Short description is required")]
		public string ShortDescription { get; set; }

		[Required(ErrorMessage = "Course category is required")]
		public string Category { get; set; }

		[Required(ErrorMessage = "Course level is required")]
		public string Level { get; set; }

		[Required(ErrorMessage = "At least one language is required")]
		public string Languages { get; set; }

		public bool IsFeatured { get; set; }

		[Required(ErrorMessage = "Course time is required")]
		public string CourseTime { get; set; }

		[Required(ErrorMessage = "Total lectures is required")]
		public int TotalLectures { get; set; }

		[Required(ErrorMessage = "Course price is required")]
		public decimal CoursePrice { get; set; }

		public bool DiscountPrice { get; set; }

		public string Description { get; set; }

		public string CourseImage { get; set; }



	}



	

}

