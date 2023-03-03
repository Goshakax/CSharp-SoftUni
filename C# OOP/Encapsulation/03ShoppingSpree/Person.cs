using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StartUp
{
    public class Person 
    {
		private string name;
		private List<Product> bagOfProducts;
		private decimal money;
		public Person(string name, decimal money)
		{
			Name = name;
			Money = money;
			BagOfProducts= new List<Product>();
		}
		public decimal Money
		{
			get { return money; }
			set 
			{
				if (value>=0)
				{
                    money = value;
                }
				else
				{
					throw new ArgumentException("Money cannot be negative"); 
				}
				
			}
		}

		public List<Product> BagOfProducts
		{
			get { return bagOfProducts; }
			set { bagOfProducts = value; }
		}

		public string Name
		{
			get { return name; }
			set 
			{
				if (!string.IsNullOrEmpty(value.Trim()))
				{
					name = value;
				}
				else
				{
                    throw new ArgumentException("Name cannot be empty");
                }
			}
		}

		public void BuyProduct(Product product)
		{
			if (!CanAfford(product))
			{
				Console.WriteLine($"{Name} can't afford {product.Name}");
			}
			else
			{
				Console.WriteLine($"{Name} bought {product.Name}");
                Money -= product.Cost;
				BagOfProducts.Add(product);
			}

		}

		private bool CanAfford(Product product)
		{
			if (Money-product.Cost>=0)
			{
				return true;
			}
			return false;
		}

        public override string ToString()
        {
			if (BagOfProducts.Count==0)
				return $"{Name} - Nothing bought";

			List<string> productsName = new List<string>();
			foreach (var prod in BagOfProducts)
			{
				productsName.Add(prod.Name);
			}
			return $"{Name} - {string.Join(", ", productsName)}";
        }

    }
}
