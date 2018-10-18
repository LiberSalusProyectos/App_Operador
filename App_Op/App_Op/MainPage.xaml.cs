using App_Op.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Op
{
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }
        public MainPage()
        {
            InitializeComponent();

            menuList = new List<MasterPageItem>();


            //Añade elementos al menu a menuList y puedes definir título, página e icono.
            menuList.Add(new MasterPageItem() { Title = "Home", Icon = "home.png", TargetType = typeof(Pag_Home) });
            menuList.Add(new MasterPageItem() { Title = "Rentas", Icon = "rent.png", TargetType = typeof(Pag_Renta) });
            menuList.Add(new MasterPageItem() { Title = "Solicitud Renta", TargetType = typeof(Pag_SolR1) });
            menuList.Add(new MasterPageItem() { Title = "Calendario", Icon = "calend.png", TargetType = typeof(Pag_Calendario) });
            menuList.Add(new MasterPageItem() { Title = "Formatos", Icon = "format.png", TargetType = typeof(Pag_Formatos) });
            menuList.Add(new MasterPageItem() { Title = "Inventario", Icon = "invent.png", TargetType = typeof(Pag_Inventario) });
            menuList.Add(new MasterPageItem() { Title = "Clientes", Icon = "clientes.png", TargetType = typeof(Pag_Clientes) });
            menuList.Add(new MasterPageItem() { Title = "Configuración", Icon = "config.png", TargetType = typeof(Pag_Configuracion) });
            menuList.Add(new MasterPageItem() { Title = "Ayuda", Icon = "ayuda.png", TargetType = typeof(Pag_Ayuda) });

            //configurando nuestra lista como ItemSource para ListView en MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;

            //Navegación inicial, esto puede ser usado para nuestra página de inicio.
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Pag_Home)));

        }

        //Evento para la selección de elementos del menú, aquí vamos a manejar la navegación 
        //basada en la selección del usuario en el menú ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;

        }

        
    }
}
