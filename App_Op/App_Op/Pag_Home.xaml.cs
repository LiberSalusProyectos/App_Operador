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
	public partial class Pag_Home : ContentPage
	{
		public Pag_Home ()
		{
			InitializeComponent ();
		}

        private void ButtonDetalleR_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag_DetalleR());
          
        }
        private void ButtonAgregar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag_SolR1());

        }
    }
}