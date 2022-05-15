using project.Models;
using project.Views;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace project.ViewModels
{
    /// <summary>
    /// ViewModel for Category page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class CategoryPageViewModel : BaseViewModel
    {
        #region Fields

        private ObservableCollection<Category> categories;

        private Command categorySelectedCommand;

        private Command notificationCommand;

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets the property that has been bound with StackLayout, which displays the categories using ComboBox.
        /// </summary>
        [DataMember(Name = "categories")]
        public ObservableCollection<Category> Categories
        {
            get
            {
                return this.categories;
            }

            set
            {
                if (this.categories == value)
                {
                    return;
                }

                this.SetProperty(ref this.categories, value);
            }
        }
        [DataMember(Name ="title")]
        public string Title { get; set; }

        #endregion

        #region Command

        /// <summary>
        /// Gets the command that will be executed when the Category is selected.
        /// </summary>
        public Command CategorySelectedCommand
        {
            get { return this.categorySelectedCommand ?? (this.categorySelectedCommand = new Command(this.CategorySelected)); }
        }

        /// <summary>
        /// Gets the command that will be executed when the Notification button is clicked.
        /// </summary>
        public Command NotificationCommand
        {
            get { return this.notificationCommand ?? (this.notificationCommand = new Command(this.NotificationClicked)); }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the Category is selected.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void CategorySelected(object obj)
        {
            string subCat = (obj as Category).Name;
            //var clientFirebase= new Firebase.Database.FirebaseClient("https://raneenxamarin-default-rtdb.firebaseio.com/");
            //var res=clientFirebase.Child("categories.json").OnceAsync<Test>();
           
            //Application.Current.MainPage.DisplayAlert("Title Api", res.ToString(), "ok");
            switch(subCat)
            {
                case "Clothes":
                    var dest = new CatalogTilePage();
                    NavigationPage.SetHasNavigationBar(dest, true);
                    NavigationPage.SetHasBackButton(dest, true);
                    Application.Current.MainPage.Navigation.PushAsync(dest);
                    break;
            }
            

        }

        /// <summary>
        /// Invoked when the notification button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void NotificationClicked(object obj)
        {
            // Do something
        }

        #endregion
    }
    public class Test
    {
        public string Name { get; set; }
    }
}