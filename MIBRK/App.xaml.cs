using Xamarin.Forms;

namespace MIBRK
{
	public partial class App : Application
	{
		public static PolicyManager PolManager { get; private set;}

		public App()
		{
			InitializeComponent();

			PolManager = new PolicyManager(new RestService());
			MainPage = new NavigationPage(new LobbyPage());

			//MainPage = new NavigationPage(new PoliciesPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
