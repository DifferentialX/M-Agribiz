using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Agribiz.Views
{
	public partial class TextDetail : StackLayout
	{
		public static readonly BindableProperty DescriptorProperty = 
			BindableProperty.Create(nameof(Descriptor), typeof(string), typeof(TextDetail));

		public string Descriptor
		{
			get
			{
				return (string)GetValue(DescriptorProperty);
			}
			set
			{
				SetValue(DescriptorProperty, value);
			}
		}

		public static readonly BindableProperty DetailProperty = 
			BindableProperty.Create(nameof(Detail), typeof(string), typeof(TextDetail));

		public string Detail
		{
			get
			{
				return (string)GetValue(DetailProperty);
			}
			set
			{
				SetValue(DetailProperty, value);
			}
		}

		public TextDetail()
		{
			InitializeComponent();
		}
	}
}