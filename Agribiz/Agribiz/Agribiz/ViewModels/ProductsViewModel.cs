using Agribiz.Helpers;
using Agribiz.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agribiz.ViewModels
{
	internal class ProductsViewModel : BaseViewModel<Product>
	{
		public ObservableRangeCollection<Product> Products { get; set; }
		public Command LoadItemsCommand { get; set; }

		public ProductsViewModel()
		{
			Title = "Browse";
			Products = new ObservableRangeCollection<Product>();
			LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

			//MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
			//{
			//	var _item = item as Item;
			//	Products.Add(_item);
			//	await DataStore.AddItemAsync(_item);
			//});
		}

		async Task ExecuteLoadItemsCommand()
		{
			if (IsBusy)
				return;

			IsBusy = true;

			try
			{
				Products.Clear();
				var items = await DataStore.GetItemsAsync(true);
				Products.ReplaceRange(items);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
				MessagingCenter.Send(new MessagingCenterAlert
				{
					Title = "Error",
					Message = "Unable to load items.",
					Cancel = "OK"
				}, "message");
			}
			finally
			{
				IsBusy = false;
			}
		}
	}
}