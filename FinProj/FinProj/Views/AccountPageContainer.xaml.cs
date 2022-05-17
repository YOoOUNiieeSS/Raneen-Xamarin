using FinProj.Data;
using FinProj.Models;
using FinProj.Views.AccountInfo;
using FinProj.Views.AccountOrders;
using FinProj.Views.AccountWishlistEmpty;
using FinProj.Views.AcountAddresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinProj.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountPageContainer : ContentPage
    {
        List<users> allUsers = new List<users>();
        users currentUser;
        List<Address> userAddress = new List<Address>();
        public AccountPageContainer()
        {
            InitializeComponent();
            frame1.BackgroundColor = frameAddress.BackgroundColor =
                frameLog.BackgroundColor = frameOrder.BackgroundColor =
                frameWish.BackgroundColor = Color.FromRgb(235, 235, 235);
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private void OnAccountInfoTapped(object sender, EventArgs e)
        {
            //DisplayAlert("Error","HI","cancel");
            Navigation.PushAsync(new ProfilePage());

        }

        private async void OnMyAddressesTapped(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new MyAddressesPage());


            allUsers = (List<users>)await myFinDB.GetAllusers();
            string mail = "Reem@gmail.com";
            currentUser = allUsers.FirstOrDefault(_user => _user.Email == mail);
            int currentUserID = currentUser.ID;
            List<Address> allAddresses = (List<Address>)await myFinDB.GetAllAddress();
            userAddress = allAddresses.Where(_address => _address.UserId == currentUserID).ToList();

            if (userAddress.Count > 0)
            {
                //isAddressEmpty = false;
                await DisplayAlert("Error", $"No.Addresses is: {userAddress.Count}", "cancel");
                await Navigation.PushAsync(new MyAddressesPage());

            }
            else
            {
                //isAddressEmpty = true;
                //await DisplayAlert("Error", $"No Records : {userAddress.Count}", "cancel");
                await Navigation.PushAsync(new AddAddressPage());

            }

        }

        private void OnMyOrdersTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyOrdersEmptyPage());

        }

        private void OnAccountWishListTapped(object sender, EventArgs e)
        {

            if (myFinDB.mywishList.Count == 0)
            {
                Navigation.PushAsync(new AccountWishListEmptyPage());

            }
            else
            {
                Navigation.PushAsync(new WishListSummaryPage());

            }

        }

        private void OnLogOut(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignPage());
        }


    }
}