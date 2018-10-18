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
	public partial class Pag_DetalleR : ContentPage
	{
		public Pag_DetalleR ()
		{
			InitializeComponent ();
		}

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as ViewModel;
            var product = e.Item as Product;
            vm.HideOrShowProduct(product);

        }
    }
}