using FinProj.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinProj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class testDB : ContentPage
    {
        public testDB()
        {
            InitializeComponent();
            btn_test.Clicked += Btn_test_Clicked;

        }

        private async void Btn_test_Clicked(object sender, EventArgs e)
        {
            //await usersDB.AddUser("Reem", "Khalil","Reem@gmail.com","010512210","Rkhalil");
            //await usersDB.AddUser("Alaa", "Khalil","Alaa@gmail.com","012982210","Akhalil");
            //await usersDB.AddUser("Khalid", "Khalil","Khalid@gmail.com","015912210","Kkhalil");
            //await usersDB.AddUser("Walid", "Wagdy","Walid@gmail.com","010917453","Wwe");

            await myFinDB.AddUser("Reem", "Khalil", "Reem@gmail.com", "Rkhalil");



            //await usersDB.AddState("Al Beheria");
            //await usersDB.AddState("Al Daqahilya");
            //await usersDB.AddState("Al Fayoum");
            //await usersDB.AddState("Al Gharbia");
            //await usersDB.AddState("Alexandra");
            //await usersDB.AddState("Aswan");
            //await usersDB.AddState("Asyut");
            //await usersDB.AddState("Bani Souaif");
            //await usersDB.AddState("Cairo");
            //await usersDB.AddState("Giza");
            //await usersDB.AddState("Luxor");

            //await usersDB.AddCity("Abu El Matamir", 1);
            //await usersDB.AddCity("Abu Hummus", 1);
            //await usersDB.AddCity("El Delengat", 1);
            //await usersDB.AddCity("Badr", 1);
            //await usersDB.AddCity("Damanhour", 1);
            //await usersDB.AddCity("Hosh Essa", 1);

            //await usersDB.AddCity("Aga", 2);
            //await usersDB.AddCity("El Gamaliya", 2);
            //await usersDB.AddCity("El Mansoura", 2);
            //await usersDB.AddCity("El Manzala", 2);
            //await usersDB.AddCity("El Matareya", 2);
            //await usersDB.AddCity("Beni Ebeid", 2);
            //await usersDB.AddCity("Belqas", 2);
            //await usersDB.AddCity("Dikirnis", 2);
            //await usersDB.AddCity("Mit Ghamr", 2);

            //await usersDB.AddCity("Al Fayoum", 3);
            //await usersDB.AddCity("Al Fatimya", 3);

            //await usersDB.AddCity("Basyoun", 4);
            //await usersDB.AddCity("El Mahalla El Kubra", 4);
            //await usersDB.AddCity("El Sunta", 4);
            //await usersDB.AddCity("Kafr El Zayat", 4);

            //await usersDB.AddCity("Al Amriya", 5);
            //await usersDB.AddCity("Al Seyouf", 5);
            //await usersDB.AddCity("City Center", 5);

            //await usersDB.AddCity("Aswan", 6);
            //await usersDB.AddCity("Edfo", 6);

            //await usersDB.AddCity("Abnub", 7);
            //await usersDB.AddCity("Abu Tig", 7);
            //await usersDB.AddCity("Asyut", 7);
            //await usersDB.AddCity("El Badari", 7);
            //await usersDB.AddCity("Dairut", 7);
            //await usersDB.AddCity("El Fath", 7);
            //await usersDB.AddCity("El Ghanayem	", 7);
            //await usersDB.AddCity("Sodfa", 7);

            //await usersDB.AddCity("El Fashn", 8);
            //await usersDB.AddCity("Beni Suef", 8);
            //await usersDB.AddCity("Biba", 8);
            //await usersDB.AddCity("Ihnasiya	", 8);
            //await usersDB.AddCity("Nasser", 8);

            //await usersDB.AddCity("Abdeen", 9);
            //await usersDB.AddCity("Ain Shams", 9);
            //await usersDB.AddCity("Amreya", 9);
            //await usersDB.AddCity("Azbakeya	", 9);
            //await usersDB.AddCity("El Basatin", 9);
            //await usersDB.AddCity("El Gamaliya", 9);
            //await usersDB.AddCity("El Khalifa", 9);
            //await usersDB.AddCity("Maadi", 9);
            //await usersDB.AddCity("El Masara	", 9);
            //await usersDB.AddCity("El Muski", 9);

            //await usersDB.AddCity("Agouza", 10);
            //await usersDB.AddCity("Dokki", 10);
            //await usersDB.AddCity("El Ayyat", 10);
            //await usersDB.AddCity("El Badrashein", 10);
            //await usersDB.AddCity("El Hawamdeya", 10);
            //await usersDB.AddCity("El Omraniya", 10);
            //await usersDB.AddCity("El Wahat El Bahariya", 10);
            //await usersDB.AddCity("El Warraq", 10);
            //await usersDB.AddCity("Giza", 10);
            //await usersDB.AddCity("Sheikh Zayed City", 10);

            //await usersDB.AddCity("Armant", 11);
            //await usersDB.AddCity("Esna", 11);
            //await usersDB.AddCity("Luxor", 11);
            //await usersDB.AddCity("Qurna", 11);
            //await usersDB.AddCity("Tiba", 11);
            List_test.ItemsSource = await myFinDB.GetAllusers();
            //List_test.ItemsSource = await usersDB.GetAllStates();
            //List_test.ItemsSource = await usersDB.GetAllCities();


            //await usersDB.deleteCity();
        }

        private void listItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}