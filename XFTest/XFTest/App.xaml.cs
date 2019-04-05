using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFTest.Utilities;
using XFTest.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFTest
{
    public partial class App : Application
    {
        public App(INavigationService navigationService)
        {
            this.InitializeComponent();

            XF.Material.Forms.Material.Init(this, "Material.Style");

            navigationService.SetRootView(ViewNames.MainView, ViewFactory.GetView(ViewNames.SecondView));
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
