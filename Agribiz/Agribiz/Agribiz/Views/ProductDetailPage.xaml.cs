
using Agribiz.ViewModels;

using Xamarin.Forms;

namespace Agribiz.Views
{
	public partial class ProductDetailPage : ContentPage
	{
		ProductsDetailViewModel viewModel;

		// Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
		public ProductDetailPage()
		{
			InitializeComponent();
		}

		public ProductDetailPage(ProductsDetailViewModel viewModel)
		{
			InitializeComponent();

			BindingContext = this.viewModel = viewModel;
		}
	}
}
