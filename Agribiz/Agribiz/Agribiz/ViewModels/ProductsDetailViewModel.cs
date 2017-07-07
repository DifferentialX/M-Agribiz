using Agribiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agribiz.ViewModels
{
	public class ProductsDetailViewModel : BaseViewModel<Product>
	{
		public Product Product { get; set; }
		public string ImageUri { get; set; }
		public ProductsDetailViewModel(Product product)
		{
			Product = product;
			Title = Product.Title;
			ImageUri = "http://m-agribiz.co/" + Product.Image;
		}
	}
}
