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
       
        Label LblMsg;
        Button btnNext;
        

        public MainPage()
        {
            InitializeComponent();
            InitializeLayout();
            
           
        }

        private void InitializeLayout()
        {
            btnNext = new Button { Text = "Next" };

            btnNext.Clicked+= (sender, e) => { ((App)this.Parent).MainPage = new SubPage(); };
            LblMsg = new Label
            {
                Text = " ",
                FontSize = 20,
                HorizontalOptions=LayoutOptions.CenterAndExpand,
                TextColor = Color.Red
            };

            Content = new StackLayout
            {
                BackgroundColor = Color.BlueViolet,
                Margin = 20,
                Children =
                {
                    new StackLayout
                    {
                        BackgroundColor=Color.DarkSeaGreen,
                        Margin=20,
                        Children=
                        {
                          new Label{Text = "לחץ על הכפתור למעבר לדף הבא",
                          TextColor = Color.LightYellow,
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
            LblMsg.Text+= $"\nYou left the main page on {DateTime.Now.ToString()}";    
        }
    }
}
