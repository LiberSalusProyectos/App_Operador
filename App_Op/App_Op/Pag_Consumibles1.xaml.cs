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
	public partial class Pag_Consumibles1 : ContentPage
	{
		public Pag_Consumibles1 ()
		{
			InitializeComponent ();
		}

        private void ButtonEquipo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag_Inventario());
        }
    }
}