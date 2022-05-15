using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinProj.Data;
using FinProj.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinProj.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class offers : ContentPage
    {
        public offers()
        {
            InitializeComponent();
        }

        private async void load(object sender, EventArgs e)
        {
            myList.ItemsSource= await myFinDB.getAllProd();
        }
    }
}