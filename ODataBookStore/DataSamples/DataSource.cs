using ODataBookStore.EDM;

namespace ODataBookStore.DataSamples
{
	public class DataSources
	{
		public IEnumerable<Book> Books { get; set; }
		public IEnumerable<Press> Presses { get; set; }

		public DataSources()
		{
			Books = new List<Book>()
			{
				new Book()
				{
					ISBN="987-654-321-1234-5",
					Title="Essential C# 5.0 (out of support)",
					Author="SONKTQ",
					Price=59.99M,
					Location=new Address()
					{
						City="Thanh Pho Ho Chi Minh",
						Street="Vinhomes Grandpark s1.06",
					},
					Press = new Press()
					{
						Name="Con mua ngang qua",
						Category=Category.Book
					}
				},
				new Book()
				{
					ISBN="987-654-321-1234-5",
					Title="Premium C# 6.0 (longterm support)",
					Author="LamLV",
					Price=29.99M,
					Location=new Address()
					{
						City="Thanh Pho Ho Chi Minh",
						Street="Vinhomes Grandpark s7.01",
					},
					Press = new Press()
					{
						Name="Dom Dom",
						Category=Category.EBook
					}
				},
				new Book()
				{
					ISBN="987-654-321-1234-5",
					Title="Premium C# 6.0 (longterm support)",
					Author="AnhTTV",
					Price=29.99M,
					Location=new Address()
					{
						City="Thanh Pho Ho Chi Minh",
						Street="Vinhomes Grandpard s5.01B",
					},
					Press = new Press()
					{
						Name="Thien Ly oi",
						Category=Category.EBook
					}
				},
				new Book()
				{
					ISBN="987-654-321-1234-5",
					Title="Premium C# 6.0 (longterm support)",
					Author="NguyenNLM",
					Price=29.99M,
					Location=new Address()
					{
						City="Thanh Pho Ho Chi Minh",
						Street="Vinhomes Grandpard s5.01B",
					},
					Press = new Press()
					{
						Name="Song Gio",
						Category=Category.EBook
					}
				}
			};
		}

	}
}
