using project.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace project.Data
{
    internal class CartProductListDatabase
    {
        static SQLiteAsyncConnection myDatabase;
        const string dbName = "raneenDb";
        static async Task Init()
        {
            //if (myDatabase != null)
            //    return;
            //else
            //{
            //    string path = Path.Combine(FileSystem.AppDataDirectory, dbName);
            //    myDatabase = new SQLiteAsyncConnection(path);
            //    await myDatabase.CreateTableAsync<Product>();
            //    await myDatabase.CreateTableAsync<users>();
            //    await myDatabase.CreateTableAsync<state>();
            //    await myDatabase.CreateTableAsync<city>();
            //    await myDatabase.CreateTableAsync<Address>();
            //    await myDatabase.CreateTableAsync<WishList>();
            //}
            string path = Path.Combine(FileSystem.AppDataDirectory, dbName);

            using (var db = new SQLite.SQLiteConnection(path))
            {
                db.DeleteAll<CartProductListDatabase>();
            }

        }
        public static async Task AddProductToCartList(Product newProd)
        {
            await Init();
            await myDatabase.InsertAsync(newProd);
        }

        public static async Task AddProductToWishList(Product newProd,int userId)
        {
            await Init();
            WishList w = new WishList()
            {
                Product=newProd,
                UserId=userId,
            };
            await myDatabase.InsertAsync(w);
        }
        public static async Task<IEnumerable<Product>> getAllProd()
        {
            await Init();
            return await myDatabase.Table<Product>().ToListAsync();
        }
        // ***************Add State**********************

        public static async Task AddState(string _stateName)
        {
            await Init();
            state _state = new state()
            {
                StateName = _stateName
            };
            await myDatabase.InsertAsync(_state);
        }
        // ***************Add City**********************
        public static async Task AddCity(string _cityName, int st_Id)
        {
            await Init();
            city _city = new city()
            {
                CityName = _cityName,
                StateId = st_Id,
            };
            await myDatabase.InsertAsync(_city);
        }

        // ***************Add User**********************

        public static async Task AddUser(string _FN, string _LN, string _mail, string _pass)
        {
            // Init();
            await Init();
            users _user = new users()
            {
                FirstName = _FN,
                LastName = _LN,
                Email = _mail,
                Password = _pass
            };
            await myDatabase.InsertAsync(_user);
        }

        // ***************Add Address**********************

        public static async Task AddAddress(int userId, string stateName, string cityName,
            string country, string street, string firstName, string lastName, string phone)
        {
            await Init();
            Address _address = new Address()
            {
                UserId = userId,
                //StateId = stateName,
                //CityId= cityName,
                StateName = stateName,
                CityName = cityName,
                Country = country,
                Street = street,
                FirstName = firstName,
                LastName = lastName,
                Phone = phone

            };
            await myDatabase.InsertAsync(_address);
        }

        // ***************Get Users**********************

        public static async Task<IEnumerable<users>> GetAllusers()
        {
            await Init();
            var allusers = await myDatabase.Table<users>().ToListAsync();
            return allusers;
        }
        // ***************Get states**********************

        public static async Task<IEnumerable<state>> GetAllStates()
        {
            await Init();
            var allstates = await myDatabase.Table<state>().ToListAsync();
            return allstates;
        }

        // ***************Get Cities**********************
        public static async Task<IEnumerable<city>> GetAllCities()
        {
            await Init();
            var allcities = await myDatabase.Table<city>().ToListAsync();
            return allcities;
        }

        // ***************Get Address**********************
        public static async Task<IEnumerable<Address>> GetAllAddress()
        {
            await Init();
            var allAddress = await myDatabase.Table<Address>().ToListAsync();
            return allAddress;
        }
        public static async Task DeleteAddress(Address _address)
        {
            await myDatabase.DeleteAsync(_address);
        }
        public static async Task UpdateAddress(Address _address)
        {
            await myDatabase.UpdateAsync(_address);
        }

    }
}
