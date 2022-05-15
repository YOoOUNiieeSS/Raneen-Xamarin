using project.Data;
using project.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace project.Views.AcountAddresses
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddAddressPage : ContentPage
    {

        //ObservableCollection<state> StatesList = new ObservableCollection<state>();
        //ObservableCollection<city> CityList = new ObservableCollection<city>();
        //ObservableCollection<city> ChoosenCityList = new ObservableCollection<city>();

        List<state> StatesList = new List<state>();
        List<city> CityList = new List<city>();
        List<city> ChoosenCityList = new List<city>();
        List<users> allUsers = new List<users>();
        List<Address> userAddress = new List<Address>();
        //ObservableCollection<Address> userAddress;
        users currentUser ;

        int cityID,stateID;
        
        string _country,cityName,stateName ,myState;
        //bool isAddressEmpty = true;
        bool isentEmpty;
        int addressID,userID;
        public AddAddressPage()
        {
            InitializeComponent();
            mainBg.BackgroundColor= Color.FromRgb(241, 241, 245);


            if (Application.Current.Properties.ContainsKey("AddressId"))
            {

                addressID = int.Parse(Application.Current.Properties["AddressId"].ToString());

            }

            if (Application.Current.Properties.ContainsKey("UserId"))
            {

                userID = int.Parse(Application.Current.Properties["UserId"].ToString());

            }

            if (Application.Current.Properties.ContainsKey("StateName"))
            {

                ent_State.Text = "";

            }
            if (Application.Current.Properties.ContainsKey("CityName"))
            {

                ent_City.Text = "";

            }

            if (Application.Current.Properties.ContainsKey("Country"))
            {

                ent_Country.Text ="";

            }

            if (Application.Current.Properties.ContainsKey("Street"))
            {

                ent_Street.Text = Application.Current.Properties["Street"].ToString();
            }
            else
            {
                ent_Street.Text = "";
            }
            if (Application.Current.Properties.ContainsKey("FirstName"))
            {

                ent_FN.Text = Application.Current.Properties["FirstName"].ToString();
            }
            else
            {
                ent_FN.Text = "";
            }
            if (Application.Current.Properties.ContainsKey("LastName"))
            {

                ent_LN.Text = Application.Current.Properties["LastName"].ToString();

            }
            else
            {
                ent_LN.Text = "";
            }
            if (Application.Current.Properties.ContainsKey("Phone"))
            {

                ent_Phone.Text = Application.Current.Properties["Phone"].ToString();

            }
            else
            {
                ent_Phone.Text = "";
            }



            if (Application.Current.Properties.ContainsKey("state"))
            {

                myState = Application.Current.Properties["state"].ToString();

            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            Action<double> callback = input => MyDraggableView.HeightRequest = input;
            double startHeight = mainDisplayInfo.Height / 15;
            double endiendHeight = 0;
            uint rate = 32;
            uint length = 500;
            Easing easing = Easing.SinOut;
            MyDraggableView.Animate("anim", callback, startHeight, endiendHeight, rate, length, easing);
        }


        private void TapGestureStates_Tapped(object sender, EventArgs e)
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            Action<double> callback = input => DraggableStates.HeightRequest = input;
            double startHeight = mainDisplayInfo.Height / 2;
            double endiendHeight = 0;
            uint rate = 32;
            uint length = 500;
            Easing easing = Easing.SinOut;
            DraggableStates.Animate("anim", callback, startHeight, endiendHeight, rate, length, easing);
        }

        private void TapGestureCities_Tapped(object sender, EventArgs e)
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            Action<double> callback = input => DraggableCities.HeightRequest = input;
            double startHeight = mainDisplayInfo.Height / 2;
            double endiendHeight = 0;
            uint rate = 32;
            uint length = 500;
            Easing easing = Easing.SinOut;
            DraggableCities.Animate("anim", callback, startHeight, endiendHeight, rate, length, easing);
        }

        private void ShowSlider(object sender, EventArgs e)
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            if (MyDraggableView.Height == 0)
            {
                Action<double> callback = input => MyDraggableView.HeightRequest = input;
                double startHeight = 0;
                double endHeight = mainDisplayInfo.Height / 15;
                uint rate = 32;
                uint length = 500;
                Easing easing = Easing.CubicOut;
                MyDraggableView.Animate("anim", callback, startHeight, endHeight, rate, length, easing);
            }
            else
            {
                TapGestureRecognizer_Tapped(sender,e);

            }
        }

        private void ShowStateSlider(object sender, EventArgs e)
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            if (DraggableStates.Height == 0)
            {
                Action<double> callback = input => DraggableStates.HeightRequest = input;
                double startHeight = 0;
                double endHeight = mainDisplayInfo.Height / 2;
                uint rate = 32;
                uint length = 500;
                Easing easing = Easing.CubicOut;
                DraggableStates.Animate("anim", callback, startHeight, endHeight, rate, length, easing);
            }
            else
            {
                TapGestureStates_Tapped(sender, e);

            }
        }

        private void ShowCitySlider(object sender, EventArgs e)
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            if (DraggableCities.Height == 0)
            {
                Action<double> callback = input => DraggableCities.HeightRequest = input;
                double startHeight = 0;
                double endHeight = mainDisplayInfo.Height / 2;
                uint rate = 32;
                uint length = 500;
                Easing easing = Easing.CubicOut;
                DraggableCities.Animate("anim", callback, startHeight, endHeight, rate, length, easing);
            }
            else
            {
                TapGestureCities_Tapped(sender, e);

            }
        }

        private async void rd_CountryPressed(object sender, CheckedChangedEventArgs e)
        {
            stateStack.IsVisible= true;
            List_States.ItemsSource = await CartProductListDatabase.GetAllStates();
           
            //List_test.ItemsSource = await CartProductListDatabase.GetAllCities();
            //List_States.ItemsSource= new string[]
            //{
            //  "Al Beheria",
            //  "Al Daqahilya",
            //  "Al Fayoum",
            //  "Al Gharbia",
            //  "Alexandra",
            //  "Aswan",
            //  "Asyut",
            //  "Bani Souaif",
            //  "Cairo",
            //  "Giza",
            //  "Luxor",
            //};
            ent_Country.Text = _country =(sender as RadioButton).Content.ToString();
            TapGestureRecognizer_Tapped(sender, e);


        }

        private async void listItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ent_State.Text= (sender as ListView).SelectedItem.ToString();
            cityStack.IsVisible = true;
            StatesList = (List<state>)await CartProductListDatabase.GetAllStates();

            state stateSelected = StatesList.FirstOrDefault(_state=>_state.StateName== ent_State.Text);
            stateID = stateSelected.StateID;
            stateName = stateSelected.StateName;
            //await DisplayAlert("Error",$"State Id is: {stateID}","cancel");
            CityList = (List<city>)await CartProductListDatabase.GetAllCities();
            ChoosenCityList = CityList.Where(_cityList => _cityList.StateId == stateID).ToList();
            List_Cities.ItemsSource = ChoosenCityList;
            TapGestureStates_Tapped(sender, e);

        }
        private void listItemCitySelected(object sender, SelectedItemChangedEventArgs e)
        {
            ent_City.Text = (sender as ListView).SelectedItem.ToString();
            city citySelected = CityList.FirstOrDefault(_state => _state.CityName == ent_City.Text);
            cityID = citySelected.CityId;
            cityName = citySelected.CityName;
            //DisplayAlert("Error", $"State Id is: {cityID}", "cancel");
            TapGestureCities_Tapped(sender, e);


        }


        private void btn_AddAddress(object sender, EventArgs e)
        {
            //isAddressEmpty = false;
            emptyAddress.IsVisible = false;
            FullAddress.IsVisible = true;
        }

     
        private void btn_NShipping(object sender, EventArgs e)
        {
            btn_yes.TextColor = Color.Black;
            btn_yes.BackgroundColor = Color.White;
            btn_No.BackgroundColor = Color.Green;
            btn_No.TextColor = Color.White;
            lbl_shipping.Text = "This is NOT default shipping Address";
            lbl_shipping.TextColor = Color.Black;

        }

        private void btn_YShipping(object sender, EventArgs e)
        {
            btn_yes.TextColor = Color.White;
            btn_yes.BackgroundColor = Color.Green;
            btn_No.BackgroundColor = Color.White;
            btn_No.TextColor = Color.Black;
            lbl_shipping.Text = "This address is default shipping Address";
            lbl_shipping.TextColor  = Color.Green;
            
        }

        private async void submitAddress(object sender, EventArgs e)
        {
            /***push ********/
            //IEnumerable<Entry> txtBoxcollection = mainBg.Children.OfType<Entry>();
            //foreach (Entry txt in txtBoxcollection) {
            //    if(txt.Text == ""||txt.Text?.Length == 0||txt.Text==string.Empty)
            //    {
            //            await DisplayAlert("Error","Please Enter all fields","cancel");
            //            isentEmpty = true;
            //            return;
            //    }
            //    else
            //    {
            //        isentEmpty = false;
            //    }
            //}
            //if (!isentEmpty)
            //{
            //    //if(ent_Phone.GetType)
            //await CartProductListDatabase.AddAddress(currentUser.ID, ent_State.Text,ent_City.Text, ent_Country.Text, ent_Street.Text,ent_FN.Text,ent_LN.Text,ent_Phone.Text);
            //await Navigation.PushAsync(new MyAddressesPage());
            //}
            if(
                ent_FN.Text?.Length == 0 ||
                ent_LN.Text?.Length == 0 ||
                ent_State.Text?.Length == 0 ||
                ent_City.Text?.Length == 0||
                ent_Country.Text?.Length == 0 ||
                ent_Street.Text?.Length == 0 ||
                ent_Phone.Text?.Length == 0
                )
            {
                await DisplayAlert("Error","Please Enter all fields","cancel");
                isentEmpty = true;
                return;
            }
            else
            {
                isentEmpty = false;
            }
            if (!isentEmpty)
            {
                //if(ent_Phone.GetType)
                if (myState == "Edit")
                {
                    Address addressToEdit = userAddress.FirstOrDefault(_address => _address.AddressId == addressID);
                    addressToEdit.FirstName = ent_FN.Text;
                    addressToEdit.LastName = ent_LN.Text;
                    addressToEdit.StateName = ent_State.Text;
                    addressToEdit.CityName = ent_City.Text;
                    addressToEdit.Street = ent_Street.Text;
                    addressToEdit.Phone = ent_Phone.Text;
                    await CartProductListDatabase.UpdateAddress(addressToEdit);
                    await Navigation.PushAsync(new MyAddressesPage());


                }
                else
                {
                    if (ent_Phone.Text.Length == 11)
                    {
                        await CartProductListDatabase.AddAddress(currentUser.ID, ent_State.Text, ent_City.Text, ent_Country.Text, ent_Street.Text, ent_FN.Text, ent_LN.Text, ent_Phone.Text);
                        myState = "Add";

                        await Navigation.PushAsync(new MyAddressesPage());
                    }
                    else
                    {
                        await DisplayAlert("Error", "Phone Number is Invalid", "cancel");

                    }
                }
            }
        }

        protected async override void OnAppearing()
        {
            //base.OnAppearing();
            allUsers = (List<users>)await CartProductListDatabase.GetAllusers();
            string mail = "Reem@gmail.com";
            currentUser = allUsers.FirstOrDefault(_user => _user.Email == mail);
            int currentUserID = currentUser.ID;
            List<Address> allAddresses = (List<Address>)await CartProductListDatabase.GetAllAddress();
            userAddress = allAddresses.Where(_address => _address.UserId == currentUserID).ToList();
            if (userAddress.Count > 0)
            {
                //isAddressEmpty = false;
                emptyAddress.IsVisible = false;
                FullAddress.IsVisible = true;

            }
            else
            {
                //isAddressEmpty = true;
                emptyAddress.IsVisible = true;
                FullAddress.IsVisible = false;
            }
            //userAddress = (ObservableCollection<Address>)allAddresses.Where(_address => _address.UserId == currentUserID);
        }
    }
  
}