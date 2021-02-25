using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingWithPagesExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubPage : ContentPage
    {
        public SubPage()
        {
            InitializeComponent();
        }

        private void BtnHome_Clicked(object sender, EventArgs e)
        {
            ((App)Parent).MainPage = ((App)App.Current).Initial;
        }

        protected override void OnAppearing()
        {
            LblTxt.Text += $"\n entered Screen on {DateTime.Now}";

        }
    }
}