using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOOP52
{
    class Product
    {
        private List<string> product;

        public List<double> Harga { get; set; }

        public List<string> GetProduct()
        {
            return product;
        }

        public void SetProduct(List<string> value)
        {
            product = value;
        }

        public Product(List<string> product, List<double> harga)
        {
            this.product = product;
            Harga = harga;
        }

        public Product()
        {
        }


        public void ShowProductHarga()
        {
            Console.WriteLine("Berikut adalah list barang sewaan ");
            Console.WriteLine("========================================");
            Console.WriteLine("{0,20}{1,10}", "Product", "Harga");
            Console.WriteLine("========================================");
            for (int i = 0; i < product.Count; i++)
            {
                Console.WriteLine("{0,20}{1,10}", product[i], "Rp." + Harga[i]);
            }
            Console.WriteLine("========================================");
        }



    }
}
