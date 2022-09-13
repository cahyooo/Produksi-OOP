using System;
using System.Collections.Generic;
using System.Text;

namespace produksi.Models
{
    class bje:mesin
    {
        public string customer { get; private set; }
        public int pilihan { get; private set; }
        private bool ulang=true;


        public void produk()
        {
            Console.WriteLine("");
            while (ulang)
            {


                Console.WriteLine("\t\t\t  1. Sinarmas 5x6 INC");
                Console.WriteLine("\t\t\t  2. SP 5x8 INC");

                Console.Write("Produk(1/2) \t\t : ");
                pilihan = int.Parse(Console.ReadLine());

                if (pilihan == 1)
                {
                    customer = "Sinarmas 5x6 INC";
                    ulang = false;
                }
                else if (pilihan == 2)
                {
                    customer = "SP 5x8 INC";
                    ulang = false;

                }
                else
                {
                    Console.WriteLine("");

                    Console.WriteLine("\t\tPilihan Yang Anda Masukan Tidak Sesuai\t\t");
                    Console.WriteLine("");
                    ulang = true;
                }
            }
        }

    }
}
