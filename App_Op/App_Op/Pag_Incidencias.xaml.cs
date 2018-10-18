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
	public partial class Pag_Incidencias : ContentPage
	{
		public Pag_Incidencias ()
		{
			InitializeComponent ();
		}

        private void ButtonRentas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag_Renta());
        }
    }
}