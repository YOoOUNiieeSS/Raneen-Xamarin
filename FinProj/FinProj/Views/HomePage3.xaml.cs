
using FinProj.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinProj.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage5 : ContentPage
    {
        public HomePage5()
        {
            InitializeComponent();
            this.BindingContext = new HomeViewModel();


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            #region RemoveNavigationStack
            //var existingPages = Shell.Current.Navigation.NavigationStack;

            //if (existingPages.Count > 1)
            //{
            //    for (int i = 1; i < existingPages.Count; i++)
            //    {
            //        if (existingPages[i] != null)
            //        {
            //            Shell.Current.Navigation.RemovePage(existingPages[i]);
            //        }
            //    }
            //}
            #endregion
        }
    }

}