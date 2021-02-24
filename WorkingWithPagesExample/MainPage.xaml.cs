using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorkingWithPagesExample
{
    public partial class MainPage : ContentPage
    {
        Label txtLbl;
        Button btnNext;
        StackLayout stck;

        public MainPage()
        {
            InitializeComponent();
            InitializeLayout();
            InitializeLabel();
            InitializeButton();
        }

        private void InitializeLayout()
        {
            stck = new StackLayout();
            stck.BackgroundColor = Color.BlueViolet;
            stck.Margin = 20;
            Content = stck;
        }

        private void InitializeButton()
        {
            btnNext = new Button();
            btnNext.Text = "Next";
            btnNext.Clicked += (sender, e) => { ((App)this.Parent).MainPage = new SubPage();  };
            if (stck == null)
                InitializeLayout();
             stck.Children.Add(btnNext);

        }

        private void InitializeLabel()
        {
            txtLbl = new Label();
            txtLbl.Text = "לחץ על הכפתור למעבר לדף הבא";
            txtLbl.TextColor = Color.LightYellow;
            txtLbl.FontSize = 25;
            if (stck == null)
                InitializeLayout();
            stck.Children.Add(txtLbl);

        }
    }
}
