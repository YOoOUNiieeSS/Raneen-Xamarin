using FinProj.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace FinProj.Data
{
    internal class myFinDB
    {
        static SQLiteAsyncConnection database;
        public static List<ProductDb> CartListProducts =new List<ProductDb> ();
        static async Task Init()
        {
            if (database != null)
            {
                // db created :
                return;
            }
            else
            {
                // create db : and set table inside db named employee
                string path = Path.Combine(FileSystem.AppDataDirectory, "projRaneemDB");
                database = new SQLiteAsyncConnection(path);
                // ad table Employee
                //await database.DropTableAsync<users>();
                await database.CreateTableAsync<users>();
                await database.CreateTableAsync<state>();
                await database.CreateTableAsync<city>();
                await database.CreateTableAsync<Address>();
                await database.CreateTableAsync<ProductDb>();
                await database.CreateTableAsync<WishList>();
                //await database.DropTableAsync<city>();
                //await database.DropTableAsync<Address>();
            }
        }
        public static async Task AddProductToCartList(Product newProd)
        {
            await Init();
            ProductDb prod = new ProductDb()
            {
                ActualPrice = newProd.ActualPrice,
                Description = newProd.Description,
                DiscountPrice = newProd.DiscountPrice,
                Id = newProd.Id,
                IsFavourite = newProd.IsFavourite,
                Name = newProd.Name,
                PreviewImage = newProd.PreviewImage,
                Summary = newProd.Summary
            };
            await database.InsertAsync(prod);
            CartListProducts.Add(prod);
        }


        public static async Task AddProductToWishList(Product newProd,int userId)
        {
            await Init();
            
            WishList w = new WishList()
            {
                ProductId = newProd.Id,
                UserID=userId,
            };
            await database.InsertAsync(w);
        }

        public static async Task<IEnumerable<ProductDb>> getAllProd()
        {
            await Init();
            return await database.Table<ProductDb>().ToListAsync();
        }
        // ***************Add State**********************

        public static async Task AddState(string _stateName)
        {
            await Init();
            state _state = new state()
            {
                StateName = _stateName
            };
            await database.InsertAsync(_state);
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
            await database.InsertAsync(_city);
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
            await database.InsertAsync(_user);
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
            await database.InsertAsync(_address);
        }

        // ***************Get Users**********************

        public static async Task<IEnumerable<users>> GetAllusers()
        {
            await Init();
            var allusers = await database.Table<users>().ToListAsync();
            return allusers;
        }
        // ***************Get states**********************

        public static async Task<IEnumerable<state>> GetAllStates()
        {
            await Init();
            var allstates = await database.Table<state>().ToListAsync();
            return allstates;
        }

        // ***************Get Cities**********************
        public static async Task<IEnumerable<city>> GetAllCities()
        {
            await Init();
            var allcities = await database.Table<city>().ToListAsync();
            return allcities;
        }

        // ***************Get Address**********************
        public static async Task<IEnumerable<Address>> GetAllAddress()
        {
            await Init();
            var allAddress = await database.Table<Address>().ToListAsync();
            return allAddress;
        }
        public static async Task DeleteAddress(Address _address)
        {
            await database.DeleteAsync(_address);
        }
        public static async Task UpdateAddress(Address _address)
        {
            await database.UpdateAsync(_address);
        }
    }
}
