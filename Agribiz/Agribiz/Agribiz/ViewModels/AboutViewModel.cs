using Agribiz.Models;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Agribiz.ViewModels
{
	public class AboutViewModel : BaseViewModel<Item>
	{
		public AboutViewModel()
		{
			Title = "About";

			OpenWebCommand = new Command(() => Device.OpenUri(new Uri("http://m-agribiz.co")));
		}

		/// <summary>
		/// Command to open browser to xamarin.com
		/// </summary>
		public ICommand OpenWebCommand { get; }
	}
}
