using ProStart.MVVM.View.Edit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinProj.Views.AccountInfo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            btn_editMail.Clicked += Btn_editMail_Clicked;
            btn_ResetPassword.Clicked += Btn_ResetPassword_Clicked;
            btn_editAccountInfo.Clicked += Btn_editAccountInfo_Clicked;
            mainBg.BackgroundColor = Color.FromRgb(241, 241, 245);  
        }

        private void Btn_ResetPassword_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Navigation.PushAsync(new ResetPasswordPage());
        }

        private void Btn_editMail_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Navigation.PushAsync(new EditMailPage());
        }

        private void Btn_editAccountInfo_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Navigation.PushAsync(new EditAccountInfoPage());

        }

    }
}