using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MIBRK
{
	public partial class PoliciesV2Page : ContentPage
	{
		public string email { get; set; }
		public PoliciesV2Page()
		{
			InitializeComponent();

		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			listView.ItemsSource = await App.PolManager.GetPoliciesAsync(email);
			spinner.IsVisible = false;
			spinner.IsRunning = false;
			listView.IsVisible = true;

		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var policyItem = e.SelectedItem as Policy;
			var policyDetailPage = new PolicyDetailPage();
			policyDetailPage.BindingContext = policyItem;
			Navigation.PushAsync(policyDetailPage);
		}
	}
}
