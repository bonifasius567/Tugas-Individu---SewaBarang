using System;
using System.Collections.Generic;

namespace BasicOOP52
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> product = new List<string>();
            product.Add("Meja");
            product.Add("Kursi");
            product.Add("Piring");
            product.Add("Mug");

            List<double> harga = new List<double>();
            harga.Add(170);
            harga.Add(120);
            harga.Add(100);
            harga.Add(75);

            int jmlProduct = product.Count;

            Product product1 = new Product(product, harga);

        A:

            Console.WriteLine("===================== ");
            Console.WriteLine("1. Tampilkan Produk ");
            Console.WriteLine("2. Sewa Product ");
            Console.WriteLine("3. Keluar ");
            Console.WriteLine("===================== ");
            Console.Write("Pilih Menu : ");
            try
            {
                int pilih = Convert.ToInt32(Console.ReadLine());
                switch (pilih)
                {
                    case 1:
                        Console.Clear();
                        product1.ShowProductHarga();
                        Console.WriteLine();
                        Console.WriteLine("Tekan enter untuk kembali");
                        Console.ReadKey();
                        Console.Clear();
                        goto A;
                    case 2:
                        Console.Clear();
                        SewaBarang(harga,product);
                        goto A;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Input. Pilih menu 1,2 atau 3");
                        goto A;
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Invalid Input. Pilih menu 1,2 atau 3");
                goto A;

            }
        }

        static void SewaBarang(List<double>harga, List<string>product)
        {
            Product product1 = new Product(product, harga);
            product1.ShowProductHarga();
            int[] jml = new int[harga.Count];
            Console.WriteLine();
            Console.WriteLine("Masukan jumlah penyewaan Barang  ");
            for (int i = 0; i < product.Count; i++)
            {
            B:
                try
                {
                    Console.Write("{0,10}{1,10}", product[i], " : ");
                    jml[i] = Convert.ToInt32(Console.ReadLine());
                    if (jml[i] < 0)
                    {
                        throw new ArgumentOutOfRangeException("Negative number is not allowed");
                    }
                }
                catch (Exception e)
                {
                    if (e is FormatException)
                    {
                        Console.WriteLine("(Inputan harus dalam bentuk Integer)");
                        goto B;
                    }
                    else if (e is ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("(Inputan harus dalam bentuk bilangan positif)");
                        goto B;
                    }
                }
            }
            Sewa sewa = new Sewa(jml, harga);
            Console.WriteLine("========================================");
            Console.WriteLine("Total Pembayaran sewaan = Rp." + sewa.totalBayar(jml, harga));
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine("Tekan enter untuk kembali ke menu utama");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
