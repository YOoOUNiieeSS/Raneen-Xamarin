using FinProj.Data;
using FinProj.Models;
using FinProj.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Montserrat-Bold.ttf",Alias="Montserrat-Bold")]
     [assembly: ExportFont("Montserrat-Medium.ttf", Alias = "Montserrat-Medium")]
     [assembly: ExportFont("Montserrat-Regular.ttf", Alias = "Montserrat-Regular")]
     [assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "Montserrat-SemiBold")]
     [assembly: ExportFont("UIFontIcons.ttf", Alias = "FontIcons")]
namespace FinProj
{
    public partial class App : Application
    {
        public static string ImageServerPath { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        List<users> users = new List<users>();
        List<state> Allstates = new List<state>();
        List<city> Allcities = new List<city>();
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new testDB();
            MainPage = new HomePage();
            //MainPage = new NavigationPage(new HomePage());
            //MainPage = new AccountPageContainer();

        }

        protected async override void OnStart()
        {
            users = (List<users>)await myFinDB.GetAllusers();
            Allstates = (List<state>)await myFinDB.GetAllStates();
            Allcities = (List<city>)await myFinDB.GetAllCities();
            if (users.Count == 0)
            {
                await myFinDB.AddUser("Reem", "Khalil", "Reem@gmail.com", "Rkhalil");
            }
            if (Allstates.Count == 0)
            {

                await myFinDB.AddState("Al Beheria");
                await myFinDB.AddState("Al Daqahilya");
                await myFinDB.AddState("Al Fayoum");
                await myFinDB.AddState("Al Gharbia");
                await myFinDB.AddState("Alexandra");
                await myFinDB.AddState("Aswan");
                await myFinDB.AddState("Asyut");
                await myFinDB.AddState("Bani Souaif");
                await myFinDB.AddState("Cairo");
                await myFinDB.AddState("Giza");
                await myFinDB.AddState("Luxor");
            }
            if (Allcities.Count == 0)
            {
                await myFinDB.AddCity("Abu El Matamir", 1);
                await myFinDB.AddCity("Abu Hummus", 1);
                await myFinDB.AddCity("El Delengat", 1);
                await myFinDB.AddCity("Badr", 1);
                await myFinDB.AddCity("Damanhour", 1);
                await myFinDB.AddCity("Hosh Essa", 1);

                await myFinDB.AddCity("Aga", 2);
                await myFinDB.AddCity("El Gamaliya", 2);
                await myFinDB.AddCity("El Mansoura", 2);
                await myFinDB.AddCity("El Manzala", 2);
                await myFinDB.AddCity("El Matareya", 2);
                await myFinDB.AddCity("Beni Ebeid", 2);
                await myFinDB.AddCity("Belqas", 2);
                await myFinDB.AddCity("Dikirnis", 2);
                await myFinDB.AddCity("Mit Ghamr", 2);

                await myFinDB.AddCity("Al Fayoum", 3);
                await myFinDB.AddCity("Al Fatimya", 3);

                await myFinDB.AddCity("Basyoun", 4);
                await myFinDB.AddCity("El Mahalla El Kubra", 4);
                await myFinDB.AddCity("El Sunta", 4);
                await myFinDB.AddCity("Kafr El Zayat", 4);

                await myFinDB.AddCity("Al Amriya", 5);
                await myFinDB.AddCity("Al Seyouf", 5);
                await myFinDB.AddCity("City Center", 5);

                await myFinDB.AddCity("Aswan", 6);
                await myFinDB.AddCity("Edfo", 6);

                await myFinDB.AddCity("Abnub", 7);
                await myFinDB.AddCity("Abu Tig", 7);
                await myFinDB.AddCity("Asyut", 7);
                await myFinDB.AddCity("El Badari", 7);
                await myFinDB.AddCity("Dairut", 7);
                await myFinDB.AddCity("El Fath", 7);
                await myFinDB.AddCity("El Ghanayem	", 7);
                await myFinDB.AddCity("Sodfa", 7);

                await myFinDB.AddCity("El Fashn", 8);
                await myFinDB.AddCity("Beni Suef", 8);
                await myFinDB.AddCity("Biba", 8);
                await myFinDB.AddCity("Ihnasiya	", 8);
                await myFinDB.AddCity("Nasser", 8);

                await myFinDB.AddCity("Abdeen", 9);
                await myFinDB.AddCity("Ain Shams", 9);
                await myFinDB.AddCity("Amreya", 9);
                await myFinDB.AddCity("Azbakeya	", 9);
                await myFinDB.AddCity("El Basatin", 9);
                await myFinDB.AddCity("El Gamaliya", 9);
                await myFinDB.AddCity("El Khalifa", 9);
                await myFinDB.AddCity("Maadi", 9);
                await myFinDB.AddCity("El Masara	", 9);
                await myFinDB.AddCity("El Muski", 9);

                await myFinDB.AddCity("Agouza", 10);
                await myFinDB.AddCity("Dokki", 10);
                await myFinDB.AddCity("El Ayyat", 10);
                await myFinDB.AddCity("El Badrashein", 10);
                await myFinDB.AddCity("El Hawamdeya", 10);
                await myFinDB.AddCity("El Omraniya", 10);
                await myFinDB.AddCity("El Wahat El Bahariya", 10);
                await myFinDB.AddCity("El Warraq", 10);
                await myFinDB.AddCity("Giza", 10);
                await myFinDB.AddCity("Sheikh Zayed City", 10);

                await myFinDB.AddCity("Armant", 11);
                await myFinDB.AddCity("Esna", 11);
                await myFinDB.AddCity("Luxor", 11);
                await myFinDB.AddCity("Qurna", 11);
                await myFinDB.AddCity("Tiba", 11);

            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
