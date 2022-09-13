using System;
using System.Collections.Generic;
using System.Text;

namespace produksi.Models
{
    class huanglong:mesin
    {

        public string customer { get; private set; }
        public int pilihan { get; private set; }
        private bool ulang = true;

        public void produk()
        {
            Console.WriteLine("");
            while (ulang)
            {


                Console.WriteLine("\t\t\t  1. Teraoka 10x15 INC");
                Console.WriteLine("\t\t\t  2. TOP 13x11 INC");

                Console.Write("Produk(1/2) \t\t : ");
                pilihan = int.Parse(Console.ReadLine());

                if (pilihan == 1)
                {
                    customer = "Teraoka 10x15 INC";
                    ulang = false;
                }
                else if (pilihan == 2)
                {
                    customer = "2. TOP 13x11 INC";
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
