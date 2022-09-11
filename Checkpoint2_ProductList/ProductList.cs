using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2_ProductList
{
	internal class ProductList
	{
		public ProductList()
		{
		}

		private List<Product>? products = new List<Product>();
		public string? searchTerm = null;
		
		public void Add()
		{
			while (true)
			{
				string category;
				string name;
				decimal price = 0;
				bool exit = false;

				Console.Write(
					"Enter new product ('q' to quit):\n" +
					"--------------------------------\n");
				while (true)
				{
					Console.Write("Category".PadRight(10) + "> ");
					category = Console.ReadLine();

					if (String.IsNullOrWhiteSpace(category))
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Empty values are not allowed.");
						Console.ResetColor();
					}
					else if (category == "q")
					{
						exit = true;
						break;
					}
					else
					{
						break;
					}
				}

				if (exit)
				{
					break;
				}
				
				while (true)
				{
					Console.Write("Name".PadRight(10) + "> ");
					name = Console.ReadLine();

					if (String.IsNullOrWhiteSpace(name))
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Empty values are not allowed.");
						Console.ResetColor();
					}
					else if (name == "q")
					{
						exit = true;
						break;
					}
					else
					{
						break;
					}
				}

				if (exit)
                {
                    break;
                }

				while (true)
				{
					Console.Write("Price".PadRight(10) + "> ");
					string? input = Console.ReadLine();
					if (input == "q")
					{
						exit = true;
						break;
					}
					else if (String.IsNullOrWhiteSpace(input))
					{
						Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Empty values are not allowed.");
						Console.ResetColor();
                    }
					else
					{
						if (!Decimal.TryParse(input, out decimal value))
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("Value must be a number.\nComma separated decimals are allowed.");
							Console.ResetColor();
						}
						else
						{
							price = Convert.ToDecimal(input);
							break;
						}
					}
				}

                if (exit)
                {
                    break;
                }

                products.Add(new Product(category, name, price)); 
				Console.Clear();
			}
			Console.Clear();
		}

		public void Display(string? searchTerm = null)
		{
			Console.Write(
				"Product list:\n" +
                "------------------------------\n" +
				"CATEGORY".PadRight(10) + "NAME".PadRight(10) + "PRICE".PadLeft(10) + "\n");

			List<Product> sortedProducts = products.OrderBy(p => p.Price).ToList();
			
			foreach (Product product in sortedProducts)
			{
				if ( !String.IsNullOrWhiteSpace(searchTerm) && product.Name.Trim().ToLower() == searchTerm.Trim().ToLower())
				{
					Console.ForegroundColor= ConsoleColor.Green;
					Console.Write($"{product.Category, -10}{product.Name, -10}{product.Price, 10:N2}\n");
					Console.ResetColor();
				}
				else
				{
					Console.Write($"{product.Category, -10}{product.Name, -10}{product.Price, 10:N2}\n");
				}
			}

			Console.Write("------------------------------\n");
			Console.Write($"TOTAL:{products.Sum(product => product.Price), 24:N2}\n");
			Console.Write("==============================\n");
		}
	}
}