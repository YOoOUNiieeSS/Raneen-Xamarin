using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinProj.Views.AccountOrders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyOrdersEmptyPage : ContentPage
    {
        public MyOrdersEmptyPage()
        {
            InitializeComponent();
        }

        private void btn_back(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();

        }
    }
}