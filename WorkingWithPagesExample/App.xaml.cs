using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingWithPagesExample
{
    public partial class App : Application
    {
        public Page Initial;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            Initial = MainPage;
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
