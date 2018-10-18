using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Op
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pag_Inventario : ContentPage
	{
		public Pag_Inventario ()
		{
			InitializeComponent ();
		}

        private void ButtonConsumibles_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag_Consumibles());
        }

        private void ButtonTotal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag_Inventario1());
        }
    }
}