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



        private void Btn_wishListStartNow(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
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