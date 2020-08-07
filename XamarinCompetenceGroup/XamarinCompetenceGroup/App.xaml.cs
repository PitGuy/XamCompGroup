using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCompetenceGroup.PageModels;

namespace XamarinCompetenceGroup
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var mainPage = FreshMvvm.FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            MainPage = new FreshMvvm.FreshNavigationContainer(mainPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
