using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MIBRK
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);

		}

		async void OnLogin(object sender, EventArgs e) {
			PoliciesV2Page policyPage = new PoliciesV2Page();
			policyPage.email = txtUsername.Text;
			await Navigation.PushAsync(policyPage);
		}

		async void OnBackHome(object sender, EventArgs e)
		{
			//await base.OnBackButtonPressed();
			await Navigation.PushAsync(new LobbyPage());
		}

		async void OnRegister(object sender, EventArgs e) {
			await Navigation.PushAsync(new RegisterPage());
		}

		async void OnRecover(object sender, EventArgs e) { 
			await Navigation.PushAsync(new RecoveryPage());
		}
	}
}
