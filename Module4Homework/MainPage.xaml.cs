using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module4Homework
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Click me again!";

        }
        void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;

        }
        void OnTextCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }
    }
}
