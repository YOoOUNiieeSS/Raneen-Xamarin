using FinProj.Data;
using FinProj.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinProj.Views.AcountAddresses
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyAddressesPage : ContentPage
    {

        List<users> allUsers = new List<users>();
        users currentUser;
        //List<Address> userAddress = new List<Address>();
        ObservableCollection<Address> AlluserAddressObser = new ObservableCollection<Address>() ;
        string cityName, stateName, country, street, firstName, lastName, phone;
        //string stateName;

        public MyAddressesPage()
        {
            InitializeComponent();
            //btn_add.BackgroundColor = Color.FromRgb(241, 241, 245);

        }

        //private void btn_AddAddress(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new AddAddressPage());

        //}

        protected async override void OnAppearing()
        {
            //base.OnAppearing();
            var userAddress = new List<Address>();
            allUsers = (List<users>)await myFinDB.GetAllusers();
            string mail = "Reem@gmail.com";
            currentUser = allUsers.FirstOrDefault(_user => _user.Email == mail);
            int currentUserID = currentUser.ID;
            List<Address> allAddresses = (List<Address>)await myFinDB.GetAllAddress();
            userAddress = allAddresses.Where(_address => _address.UserId == currentUserID).ToList();
            var userAddressObser = new ObservableCollection<Address>(userAddress);
            AlluserAddressObser = userAddressObser;
            List_test.ItemsSource = AlluserAddressObser;

            if (userAddress.Count > 0)
            {
                //isAddressEmpty = false;
                await DisplayAlert("Error", $"No.Addresses is: {userAddress.Count}", "cancel");

            }
            else
            {
                //isAddressEmpty = true;
                await DisplayAlert("Error", $"No Records : {userAddress.Count}", "cancel");

            }

            if (Application.Current.Properties.ContainsKey("StateName"))
            {

                stateName = Application.Current.Properties["StateName"].ToString();
            }
            if (Application.Current.Properties.ContainsKey("CityName"))
            {

                cityName = Application.Current.Properties["CityName"].ToString();
            }
            if (Application.Current.Properties.ContainsKey("Country"))
            {

                country = Application.Current.Properties["Country"].ToString();

            }
            if (Application.Current.Properties.ContainsKey("Street"))
            {

                street = Application.Current.Properties["Street"].ToString();
            }
            if (Application.Current.Properties.ContainsKey("FirstName"))
            {

                firstName = Application.Current.Properties["FirstName"].ToString();
            }
            if (Application.Current.Properties.ContainsKey("LastName"))
            {

                lastName = Application.Current.Properties["LastName"].ToString();

            }
            if (Application.Current.Properties.ContainsKey("Phone"))
            {

                phone = Application.Current.Properties["Phone"].ToString();

            }
        }

        private void listItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //List_test.SelectedItem = null;
        }

        private void List_test_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //if (e.Item == null) return;

            // Optionally pause a bit to allow the preselect hint.
            //Task.Delay(500);

            // Deselect the item.
            //if (sender is ListView lv) lv.SelectedItem = null;

        }

        private async  void btn_addAditionalAddress(object sender, EventArgs e)
        {
            //Application.Current.Properties["StateName"] = null;
            //Application.Current.Properties["CityName"] = null;
            //Application.Current.Properties["Country"] = null;
            //Application.Current.Properties["Street"] = null;
            //Application.Current.Properties["FirstName"] = null;
            //Application.Current.Properties["LastName"] = null;
            //Application.Current.Properties["Phone"] = null;
            Application.Current.Properties["StateName"] = "";
            Application.Current.Properties["CityName"] = "";
            Application.Current.Properties["Country"] = "";
            Application.Current.Properties["Street"] = "";
            Application.Current.Properties["FirstName"] = "";
            Application.Current.Properties["LastName"] = "";
            Application.Current.Properties["Phone"] = "";
            Application.Current.Properties["state"] = "Add";

            await Navigation.PushAsync(new AddAddressPage());
        }

        private async void Delete_AddressClicked(object sender, EventArgs e)
        {
            Address selA = ((sender as MenuItem).CommandParameter as Address);
            await myFinDB.DeleteAddress(selA);
            AlluserAddressObser.Remove(((sender as MenuItem).CommandParameter as Address));
            if (AlluserAddressObser.Count == 0)
            {
                await Navigation.PushAsync(new AddAddressPage());

            }

        }

        private void Edit_AddressClicked(object sender, EventArgs e)
        {
            //Address editAdress = ((sender as MenuItem).CommandParameter as Address);

            Application.Current.Properties["AddressId"] = ((sender as MenuItem).CommandParameter as Address).AddressId;
            Application.Current.Properties["UserId"] = ((sender as MenuItem).CommandParameter as Address).UserId;
            Application.Current.Properties["StateName"] = ((sender as MenuItem).CommandParameter as Address).StateName;
            Application.Current.Properties["CityName"] = ((sender as MenuItem).CommandParameter as Address).CityName;
            Application.Current.Properties["Country"] = ((sender as MenuItem).CommandParameter as Address).Country;
            Application.Current.Properties["Street"] = ((sender as MenuItem).CommandParameter as Address).Street;
            Application.Current.Properties["FirstName"] = ((sender as MenuItem).CommandParameter as Address).FirstName;
            Application.Current.Properties["LastName"] = ((sender as MenuItem).CommandParameter as Address).LastName;
            Application.Current.Properties["Phone"] = ((sender as MenuItem).CommandParameter as Address).Phone;
            Application.Current.Properties["state"] = "Edit";

            Navigation.PushAsync(new AddAddressPage());

        }
    }
}