using AssociationAlgorithmExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAlgorithmExample.TestData
{
	public static class GetTestData
	{
		public static IEnumerable<Product> GetProducts()
		{
			var products = new List<Product>() {
			new Product { ProductId =1, Name= "Milk" },
			new Product { ProductId =2, Name= "Bread" },
			new Product { ProductId =3, Name= "Shoes" },
			new Product { ProductId =4,Name ="Coffee" },
			new Product { ProductId =5, Name= "Cup" },
				};
			return products;
		}

		public static IEnumerable<LineItem> GetLineItems()
		{

			var lineItems = new List<LineItem>() {
				new LineItem { ProductId =1, Id=1, OrderId=1},
				new LineItem { ProductId =2, Id=2, OrderId=1},
				new LineItem { ProductId =1, Id=3, OrderId=2},
				new LineItem { ProductId =2, Id=4, OrderId=2},
				new LineItem { ProductId =3, Id=5, OrderId=3},
				new LineItem { ProductId =4, Id=6, OrderId=3},
				new LineItem { ProductId =5, Id=7, OrderId=3},
				new LineItem { ProductId =3, Id=8, OrderId=4},
				new LineItem { ProductId =4, Id=9, OrderId=5},
				new LineItem { ProductId =5, Id=10, OrderId=5},
				new LineItem { ProductId =1, Id=11, OrderId=6},
				new LineItem { ProductId =4, Id=12, OrderId=6},
				new LineItem { ProductId =1, Id=13, OrderId=7},
				new LineItem { ProductId =4, Id=14, OrderId=7},
				new LineItem { ProductId =2, Id=15, OrderId=8},
				new LineItem { ProductId =4, Id=16, OrderId=8},
				new LineItem { ProductId =5, Id=17, OrderId=8},
				new LineItem { ProductId =3, Id=18, OrderId=9},
				new LineItem { ProductId =4, Id=19, OrderId=9},
				new LineItem { ProductId =5, Id=20, OrderId=9}

			};
			return lineItems;
		}
	}
}

