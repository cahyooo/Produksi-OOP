using System;
using System.Collections.Generic;
using System.Text;

namespace produksi.Models
{
    public class karyawan
    {

        public string nama { get; private set; }
        public string jadwal { get; private set; }

        public string shift { get; private set; }
        private bool ulang { get; set; }


        public void identitas()
        {
            Console.WriteLine("--------------------------- Program Input Produksi Harian ---------------------------");
            Console.WriteLine("");


            Console.Write("Nama Operator \t\t : ");
            nama = Console.ReadLine();
        }

        public void waktu()
        {
            karyawan karyawan = new karyawan();
            karyawan.ulang = true;
            while (karyawan.ulang)
            {
            Console.WriteLine("");
            Console.WriteLine("\t\t\t  1. Shift A");
            Console.WriteLine("\t\t\t  2. Shift B");
            Console.WriteLine("\t\t\t  3. Shift C");


            Console.Write("Shift(1/2/3) \t\t : ");
            jadwal = Console.ReadLine();

            if (jadwal == "1")
            {
                shift = "A (pagi)";
                    karyawan.ulang = false;
            }
            else if(jadwal == "2"){
                    shift = "B (Sore)";
                    karyawan.ulang = false;


                }
            else if (jadwal == "3")
            {
                    shift = "C (malam)";
                    karyawan.ulang = false;

                }
                else
                {
                    Console.WriteLine("");

                    Console.WriteLine("\t\tPilihan Yang Anda Masukan Tidak Sesuai\t\t");
                    Console.WriteLine("");
                    karyawan.ulang = true;
                }
            }
        }
    }
}
