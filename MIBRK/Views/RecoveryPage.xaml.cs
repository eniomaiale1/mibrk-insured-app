using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MIBRK
{
	public partial class RecoveryPage : ContentPage
	{
		public RecoveryPage()
		{
			InitializeComponent();
		}

		void OnRecover(object sender, EventArgs e)
		{
			DisplayAlert("Alert", "Password has been recoverd", "OK");
		}
	}
}
