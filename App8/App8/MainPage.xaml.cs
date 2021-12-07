using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void data_DateSelected(object sender, DateChangedEventArgs e)
        {
            int ag = DateTime.Now.Year - data.Date.Year;
            if (DateTime.Now.Month < data.Date.Month || (DateTime.Now.Month == data.Date.Month &&
                DateTime.Now.Month < data.Date.Month))
            {
                ag--;
            }
            age.Text = "Возраст-" + ag.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
