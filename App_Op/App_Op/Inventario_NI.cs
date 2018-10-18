using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace App_Op
{
   public class Inventario_NI
    {
        private NoInvasivo _oldProduct;

        public ObservableCollection<NoInvasivo> Equipos { get; set; }

        public Inventario_NI()
        {
            Equipos = new ObservableCollection<NoInvasivo>
            {
                new NoInvasivo
                {
                    Title = "01",

                },
                new NoInvasivo
                {
                    Title="02",
                },
                new NoInvasivo
                {
                    Title="03",
                },
                new NoInvasivo
                {
                    Title="04",
                },
                new NoInvasivo
                {
                    Title="05",
                },
                new NoInvasivo
                {
                    Title="06",
                },
            };

        }

        internal void HideOrShowProduct(NoInvasivo product)
        {
            if (_oldProduct == product)
            {
                product.IsVisible = !product.IsVisible;
                UpdateProducts(product);
            }
            else
            {
                if (_oldProduct != null)
                {
                    _oldProduct.IsVisible = false;
                    UpdateProducts(_oldProduct);
                }
                product.IsVisible = true;
                UpdateProducts(product);
            }
            _oldProduct = product;
        }

        private void UpdateProducts(NoInvasivo product)
        {
            var index = Equipos.IndexOf(product);
            Equipos.Remove(product);
            Equipos.Insert(index, product);
        }
   }
}
