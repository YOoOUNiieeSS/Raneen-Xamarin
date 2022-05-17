using FinProj.Data;
using FinProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinProj.Views.AccountWishlistEmpty
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountWishListEmptyPage : ContentPage
    {
        List<WishList> myWishList = new List<WishList>();

        public AccountWishListEmptyPage()
        {
            InitializeComponent();
        }



        private async void Btn_wishListStartNow(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new CategoryTilePage());
            //Routing.RegisterRoute("Home Page", typeof(HomePage));
            //await Shell.Current.GoToAsync("../../Cart");
            //await Shell.Current.Navigation.PushModalAsync(new HomePage5());
            await Shell.Current.Navigation.PopToRootAsync();
        }

        protected  override void OnAppearing()
        {
            //myWishList = (List<WishList>)await myFinDB.GetWishList();
            if(myFinDB.mywishList.Count==0)
            {
                mainStack.IsVisible = true;

            }
            //if (myWishList.Count == 0)
            //{
            //    mainStack.IsVisible = true;
            //}

        }
    }
}