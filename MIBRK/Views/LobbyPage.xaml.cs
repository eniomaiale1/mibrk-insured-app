using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MIBRK
{
	public partial class LobbyPage : ContentPage
	{
		public LobbyPage()
		{
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);
		}

		async void OnMyPolicies(object sender, EventArgs e)
		{
			LoginPage loginPage = new LoginPage();
			await Navigation.PushAsync(loginPage);
		}

		void OnOpenTwitter(object sender, EventArgs e) {
			Device.OpenUri(new Uri("https://twitter.com/miami_ins_brks"));
		}
		void OnOpenContact(object sender, EventArgs e)
		{
			Device.OpenUri(new Uri("https://twitter.com/miami_ins_brks"));
		}
		void OnOpenFacebook(object sender, EventArgs e)
		{
			Device.OpenUri(new Uri("https://www.facebook.com/miamiinsurancebrokers/"));
		}
		void OnOpenInstagram(object sender, EventArgs e)
		{
			Device.OpenUri(new Uri("https://www.instagram.com/miami_insurance_brokers/"));
		}
	}
}
