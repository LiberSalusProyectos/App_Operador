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
	public partial class Pag_Inventario1 : ContentPage
	{
		public Pag_Inventario1 ()
		{
			InitializeComponent ();
		}

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as Inventario_NI;
            var product = e.Item as NoInvasivo;
            vm.HideOrShowProduct(product);

        }
        private void Boton_Consumibles(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pag_Consumibles());
        }
    }
}