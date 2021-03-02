using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorkingWithPagesExample
{
    /// <summary>
    /// sub page has a label and a home button.
    /// when pressed it changes back the MainPage Property of the App to the Main Page.
    /// Override OnAppearing()- set the label text to the current date and time.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
   
   
    public partial class SubPage : ContentPage
    {
        public SubPage()
        {
            InitializeComponent();
        }

        private void BtnHome_Clicked(object sender, EventArgs e)
        {
            ((App)App.Current).MainPage = ((App)App.Current).Initial;
        }

        protected override void OnAppearing()
        {
            LblTxt.Text += $"\n entered Screen on {DateTime.Now}";

        }
    }
}