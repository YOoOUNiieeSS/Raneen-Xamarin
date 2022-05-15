using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProStart.MVVM.View.Edit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditAccountInfoPage : ContentPage
    {
        public EditAccountInfoPage()
        {
            InitializeComponent();
            mainBg.BackgroundColor= Color.FromRgb(241, 241, 245);
        }
    }
}