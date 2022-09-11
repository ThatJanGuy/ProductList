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
			List<Product> sortedProducts = products.OrderBy(p => p.Price).ToList();

			Console.Write(
				"Product list:\n" +
                "-------------------------------------------------------------------\n" +
				"CATEGORY".PadRight(20) + " | " + "NAME".PadRight(20) + " | " + "PRICE".PadLeft(20) + "\n");
			
			foreach (Product product in sortedProducts)
			{
				Console.Write($"{product.Category, -20} | {product.Name, -20} | {product.Price, 20:N2}\n");
			}

			Console.Write("-------------------------------------------------------------------\n");
			Console.Write($"TOTAL:{products.Sum(product => product.Price), 60:N2}\n");
			Console.Write("===================================================================\n");
		}
	}
}