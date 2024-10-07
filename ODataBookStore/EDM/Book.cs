using System.ComponentModel.DataAnnotations;

namespace ODataBookStore.EDM
{
	public class Book
	{
		public int Id { get; set; }

		[Required]
		public string ISBN { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public string Author { get; set; }

		[Range(0, double.MaxValue)]
		public decimal Price { get; set; }

		public Address Location { get; set; }

		public Press Press { get; set; }
	}
}
