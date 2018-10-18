using System;
using App_Op.MenuItems;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Op.Vistas;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Op
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pag_Login : ContentPage
    {
        public Pag_Login()
        {
            InitializeComponent();
        }

        async void LoginButton_Clicked(object sender, EventArgs e)
        {
            User user = new User(entradaCorreo.Text, entradaPassword.Text);
            if (user.CheckInformation())
            {
                await DisplayAlert("Login", "Acceso Correcto", "Ok");
                await Navigation.PushModalAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Login", "Usuario o contraseña incorrectos, vuelva a intentarlo", "Ok");
                await Navigation.PushModalAsync(new Pag_Login());

            }
        }
    }
}
