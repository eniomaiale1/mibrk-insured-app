using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MIBRK
{
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage()
		{
			InitializeComponent();
		}
		async void OnRegister(object sender, EventArgs e) { 
			await DisplayAlert("Alert", "Your user has been created", "OK");
		}
	}
}
