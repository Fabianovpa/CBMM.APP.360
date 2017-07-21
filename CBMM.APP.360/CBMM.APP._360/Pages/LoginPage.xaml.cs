using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CBMM.APP._360.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private void bEnter_Clicked(object sender, EventArgs e)
        {
            RedirectToMenuPage();
            return;
        }

        void RedirectToMenuPage()
        {
            // manager position must not be tracked





            Application.Current.MainPage = new MainPage();
        }
    }
}