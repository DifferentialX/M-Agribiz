using Agribiz.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Agribiz
{
	public partial class App : Application
	{
		public static Color TabColor { get; set; }
		public App()
		{
			InitializeComponent();

			TabColor = (Color)this.Resources["Agrigreen"];

			SetMainPage();
		}

		public static void SetMainPage()
		{

			Current.MainPage = new TabbedPage
			{
				Children =
				{
					#pragma warning disable CS0618 // Type or member is obsolete

					//new NavigationPage(new ItemsPage())
					//{
					//	Title = "Browse",
					//	Icon = Device.OnPlatform("tab_feed.png",null,null)
					//},
					new NavigationPage(new ProductsPage())
					{
						Title = "Produits",
						Icon = Device.OnPlatform("tab_feed.png",null,null)
					},
					new NavigationPage(new AboutPage())
					{
						Title = "About",
						Icon = Device.OnPlatform("tab_about.png",null,null)
					},

					#pragma warning restore CS0618 // Type or member is obsolete
				},
				BarBackgroundColor = TabColor
			};
		}
		
	}
}
