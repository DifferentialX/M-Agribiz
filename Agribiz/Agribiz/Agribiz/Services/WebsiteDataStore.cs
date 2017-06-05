using Agribiz.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(Agribiz.Services.WebsiteDataStore))]
namespace Agribiz.Services
{
	class WebsiteDataStore : IDataStore<Product>
	{
		public Task<Product> GetItemAsync(string id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Product>> GetItemsAsync(bool forceRefresh = false)
		{
			string data = "";
			using (var client = new HttpClient())
			{
				var request = new HttpRequestMessage(HttpMethod.Get, "http://m-agribiz.co/app/");
				var responseTask = client.SendAsync(request);
				var response = await responseTask;
				if (response.IsSuccessStatusCode)
				{
					data = await response.Content.ReadAsStringAsync();
				}
			}
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(data);
		}

		public Task InitializeAsync()
		{
			throw new NotImplementedException();
		}

		public Task<bool> PullLatestAsync()
		{
			throw new NotImplementedException();
		}

		public Task<bool> SyncAsync()
		{
			throw new NotImplementedException();
		}


		#region Not Implemented for Version 1

		public Task<bool> AddItemAsync(Product item)
		{
			throw new NotImplementedException();
		}

		public Task<bool> DeleteItemAsync(Product item)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateItemAsync(Product item)
		{
			throw new NotImplementedException();
		}
		#endregion Not Implemented for Version 1
	}
}
