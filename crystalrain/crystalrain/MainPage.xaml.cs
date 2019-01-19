using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace crystalrain
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Google_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Game();
        }
    }
}
