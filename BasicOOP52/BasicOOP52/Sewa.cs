using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOOP52
{
    class Sewa : Product
    {
        public int[] Jumlah { get; set; }


        public Sewa (int[] jumlah,List<double> harga) : base()
        {
            Harga = harga;
            Jumlah = jumlah;
        }

        public double totalBayar(int[] jumlah, List<double> harga)
        {
            double total, hasil;
            hasil = 0;
            int jmlProduct = harga.Count;
            for (int i = 0; i < jmlProduct; i++)
            {
                total = (jumlah[i] * harga[i]);
                hasil = hasil + total;
            }
            return hasil;
        }
    }
}
