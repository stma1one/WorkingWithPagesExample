using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorkingWithPagesExample
{
    /// <summary>
    /// page containing image and a button.
    /// all layouts are created dynamically
    /// when pressing the button, the event handler changes the main App MainPage to the second page.
    /// there is an override OnDisappearing which adds to a label's text The date and time when left the page
    /// </summary>
    public partial class MainPage : ContentPage
    {
       
        Label LblMsg;
        Button btnNext;
        
        

        public MainPage()
        {
            InitializeComponent();
            InitializeLayout();
            Title = "Hapoel Holon";
           
        }

        private void InitializeLayout()
        {
            btnNext = new Button { Text = "Next" };
           
            //dynamically adds function when the event raises- change the App's MainPage property to subPage
            btnNext.Clicked+= (sender, e) => { ((App)App.Current).MainPage = new SubPage(); };
            LblMsg = new Label
            {
                Text = " ",
                FontSize = 20,
                HorizontalOptions=LayoutOptions.CenterAndExpand,
                TextColor = Color.Red
            };

            Content = new StackLayout
            {
                BackgroundColor = Color.Purple,
                Margin = 20,
                Children =
                {
                    new StackLayout
                    {
                        BackgroundColor=Color.Yellow,
                        Margin=20,
                        Children=
                        {
                          new Image{Source="https://static.wixstatic.com/media/ff046b_88fb2c5aa50344309b9127de0911f349~mv2.jpg/v1/fit/w_2500,h_1330,al_c/ff046b_88fb2c5aa50344309b9127de0911f349~mv2.jpg"},
                          new Label{Text = "לחץ על הכפתור למעבר לדף הבא",
                          TextColor = Color.MediumPurple,
                          FontSize = 25 },
                          btnNext,
                          LblMsg
                        }
                        
                            
                    }
                    

                }
            };
            
            
           
        }

          
        protected override void OnDisappearing()
        {
            LblMsg.Text += $"\nYou left the main page on {DateTime.Now}";
        }
    }
}
