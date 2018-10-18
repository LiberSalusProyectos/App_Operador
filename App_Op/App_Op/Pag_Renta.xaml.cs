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
	public partial class Pag_Renta : ContentPage
	{
		public Pag_Renta ()
		{
			InitializeComponent ();
		}

        private void ButtonIncidencias_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag_Incidencias());
        }

        private void ButtonDetalleR_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag_DetalleR());
        }
    }
}