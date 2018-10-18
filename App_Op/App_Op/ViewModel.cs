using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace App_Op
{
    public class ViewModel
    {
        private Product _oldProduct;

        public ObservableCollection<Product> Products { get; set; }

        public ViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Title = "Llegada",

                },
                new Product
                {
                    Title="Transporte",
                },
                new Product
                {
                    Title="Capacitación",
                },
                new Product
                {
                    Title="Calibración y puesta en marcha",
                },
            };
        }

        internal void HideOrShowProduct(Product product)
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

        private void UpdateProducts(Product product)
        {
            var index = Products.IndexOf(product);
            Products.Remove(product);
            Products.Insert(index, product);
        }
    }
}
