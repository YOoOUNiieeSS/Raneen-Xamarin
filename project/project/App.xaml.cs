using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using project.Views;
using RaneenXamarinProject.Views;
using project.Models;
using System.Collections.Generic;
using project.Data;

[assembly: ExportFont("Montserrat-Bold.ttf",Alias="Montserrat-Bold")]
     [assembly: ExportFont("Montserrat-Medium.ttf", Alias = "Montserrat-Medium")]
     [assembly: ExportFont("Montserrat-Regular.ttf", Alias = "Montserrat-Regular")]
     [assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "Montserrat-SemiBold")]
     [assembly: ExportFont("UIFontIcons.ttf", Alias = "FontIcons")]
namespace project
{
    public partial class App : Application
    {
        List<users> users = new List<users>();
        List<state> Allstates = new List<state>();
        List<city> Allcities = new List<city>();
        public static string ImageServerPath { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new BottomNavigationPage();
            //MainPage = new project.Views.Page1();
            //MainPage = new CategoryTilePage();
            MainPage = new project.Views.HomePage();
            //var HomePage = new HomePage();
            //NavigationPage.SetHasNavigationBar(HomePage, false);
            //MainPage = new NavigationPage(HomePage);
        }
        /*
        protected async override void OnStart()
        {/*
            users = (List<users>)await CartProductListDatabase.GetAllusers();
            Allstates = (List<state>)await CartProductListDatabase.GetAllStates();
            Allcities = (List<city>)await CartProductListDatabase.GetAllCities();
            if (users.Count == 0)
            {
                await CartProductListDatabase.AddUser("Reem", "Khalil", "Reem@gmail.com", "Rkhalil");
            }
            if (Allstates.Count == 0)
            {

                await CartProductListDatabase.AddState("Al Beheria");
                await CartProductListDatabase.AddState("Al Daqahilya");
                await CartProductListDatabase.AddState("Al Fayoum");
                await CartProductListDatabase.AddState("Al Gharbia");
                await CartProductListDatabase.AddState("Alexandra");
                await CartProductListDatabase.AddState("Aswan");
                await CartProductListDatabase.AddState("Asyut");
                await CartProductListDatabase.AddState("Bani Souaif");
                await CartProductListDatabase.AddState("Cairo");
                await CartProductListDatabase.AddState("Giza");
                await CartProductListDatabase.AddState("Luxor");
            }
            if (Allcities.Count == 0)
            {
                await CartProductListDatabase.AddCity("Abu El Matamir", 1);
                await CartProductListDatabase.AddCity("Abu Hummus", 1);
                await CartProductListDatabase.AddCity("El Delengat", 1);
                await CartProductListDatabase.AddCity("Badr", 1);
                await CartProductListDatabase.AddCity("Damanhour", 1);
                await CartProductListDatabase.AddCity("Hosh Essa", 1);

                await CartProductListDatabase.AddCity("Aga", 2);
                await CartProductListDatabase.AddCity("El Gamaliya", 2);
                await CartProductListDatabase.AddCity("El Mansoura", 2);
                await CartProductListDatabase.AddCity("El Manzala", 2);
                await CartProductListDatabase.AddCity("El Matareya", 2);
                await CartProductListDatabase.AddCity("Beni Ebeid", 2);
                await CartProductListDatabase.AddCity("Belqas", 2);
                await CartProductListDatabase.AddCity("Dikirnis", 2);
                await CartProductListDatabase.AddCity("Mit Ghamr", 2);

                await CartProductListDatabase.AddCity("Al Fayoum", 3);
                await CartProductListDatabase.AddCity("Al Fatimya", 3);

                await CartProductListDatabase.AddCity("Basyoun", 4);
                await CartProductListDatabase.AddCity("El Mahalla El Kubra", 4);
                await CartProductListDatabase.AddCity("El Sunta", 4);
                await CartProductListDatabase.AddCity("Kafr El Zayat", 4);

                await CartProductListDatabase.AddCity("Al Amriya", 5);
                await CartProductListDatabase.AddCity("Al Seyouf", 5);
                await CartProductListDatabase.AddCity("City Center", 5);

                await CartProductListDatabase.AddCity("Aswan", 6);
                await CartProductListDatabase.AddCity("Edfo", 6);

                await CartProductListDatabase.AddCity("Abnub", 7);
                await CartProductListDatabase.AddCity("Abu Tig", 7);
                await CartProductListDatabase.AddCity("Asyut", 7);
                await CartProductListDatabase.AddCity("El Badari", 7);
                await CartProductListDatabase.AddCity("Dairut", 7);
                await CartProductListDatabase.AddCity("El Fath", 7);
                await CartProductListDatabase.AddCity("El Ghanayem	", 7);
                await CartProductListDatabase.AddCity("Sodfa", 7);

                await CartProductListDatabase.AddCity("El Fashn", 8);
                await CartProductListDatabase.AddCity("Beni Suef", 8);
                await CartProductListDatabase.AddCity("Biba", 8);
                await CartProductListDatabase.AddCity("Ihnasiya	", 8);
                await CartProductListDatabase.AddCity("Nasser", 8);

                await CartProductListDatabase.AddCity("Abdeen", 9);
                await CartProductListDatabase.AddCity("Ain Shams", 9);
                await CartProductListDatabase.AddCity("Amreya", 9);
                await CartProductListDatabase.AddCity("Azbakeya	", 9);
                await CartProductListDatabase.AddCity("El Basatin", 9);
                await CartProductListDatabase.AddCity("El Gamaliya", 9);
                await CartProductListDatabase.AddCity("El Khalifa", 9);
                await CartProductListDatabase.AddCity("Maadi", 9);
                await CartProductListDatabase.AddCity("El Masara	", 9);
                await CartProductListDatabase.AddCity("El Muski", 9);

                await CartProductListDatabase.AddCity("Agouza", 10);
                await CartProductListDatabase.AddCity("Dokki", 10);
                await CartProductListDatabase.AddCity("El Ayyat", 10);
                await CartProductListDatabase.AddCity("El Badrashein", 10);
                await CartProductListDatabase.AddCity("El Hawamdeya", 10);
                await CartProductListDatabase.AddCity("El Omraniya", 10);
                await CartProductListDatabase.AddCity("El Wahat El Bahariya", 10);
                await CartProductListDatabase.AddCity("El Warraq", 10);
                await CartProductListDatabase.AddCity("Giza", 10);
                await CartProductListDatabase.AddCity("Sheikh Zayed City", 10);

                await CartProductListDatabase.AddCity("Armant", 11);
                await CartProductListDatabase.AddCity("Esna", 11);
                await CartProductListDatabase.AddCity("Luxor", 11);
                await CartProductListDatabase.AddCity("Qurna", 11);
                await CartProductListDatabase.AddCity("Tiba", 11);

            }
        }*/

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
