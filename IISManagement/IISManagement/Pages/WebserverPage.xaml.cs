using System;
using System.Collections.Generic;
using IISManagement.Core;
using Xamarin.Forms;

namespace IISManagement
{
	public partial class WebserverPage : ContentPage
	{
		public WebserverPage()
		{
			var viewModel = new WebserverViewModel();
			this.BindingContext = viewModel;

			InitializeComponent();
		}
	}
}
