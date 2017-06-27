using System;

using Agribiz.Models;
using Agribiz.ViewModels;

using Xamarin.Forms;

namespace Agribiz.Views
{
	public partial class ProductsPage : ContentPage
	{
		ProductsViewModel viewModel;

		public ProductsPage()
		{
			InitializeComponent();

			BindingContext = viewModel = new ProductsViewModel();
		}

		async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
		{
			var item = args.SelectedItem as Product;
			if (item == null)
				return;

			await Navigation.PushAsync(new ProductDetailPage(new ProductsDetailViewModel(item)));

			// Manually deselect item
			ItemsListView.SelectedItem = null;
		}

		async void AddItem_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NewItemPage());
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (viewModel.Products.Count == 0)
				viewModel.LoadItemsCommand.Execute(null);
		}
	}
}
