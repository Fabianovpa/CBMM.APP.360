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
    public partial class Videos : ContentPage
    {
        public Videos()
        {
            InitializeComponent();
        }

        private void videoList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}