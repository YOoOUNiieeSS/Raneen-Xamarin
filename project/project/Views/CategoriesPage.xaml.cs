using RaneenXamarinProject;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RaneenXamarinProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {
        public CategoriesPage()
        {
            InitializeComponent();
            //this.BindingContext = new CategoryPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            #region RemoveNavigationStack
            //var existingPages = Shell.Current.Navigation.NavigationStack;

            //if (existingPages.Count > 1)
            //{
            //    for (int i = 1; i < existingPages.Count; i++)
            //    {
            //        if (existingPages[i] != null)
            //        {
            //            Shell.Current.Navigation.RemovePage(existingPages[i]);
            //        }
            //    }
            //}
            #endregion
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width < height)
            {
                if (this.CategoryTile.LayoutManager is GridLayout)
                {
                    (this.CategoryTile.LayoutManager as GridLayout).SpanCount = 2;
                }
            }
            else
            {
                if (this.CategoryTile.LayoutManager is GridLayout)
                {
                    (this.CategoryTile.LayoutManager as GridLayout).SpanCount = 3;
                }
            }
        }
    }
}