using Glactic.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Glactic
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Views.GlacticPage();//
            MainPage = new NavigationPage(new GlacticPage());
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
