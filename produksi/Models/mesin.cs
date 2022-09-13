using System;
using System.Collections.Generic;
using System.Text;

namespace produksi.Models
{
    class mesin
    {
        public string nama_mesin { get; private set; }
        public int pilihan { get; private set; }
        public int target { get; private set; }
        public int selesai { get; private set; }
        public int kurang { get; private set; }
        public string harian { get; private set; }
        public string nama_customer { get; private set; }
        public int cek { get; private set; }
        private bool ulang;





        //public void customer()
        //{
        //    bje bje = new bje();
        //    huanglong huanglong = new huanglong();

        //    if (nama_mesin == "BJE" )
        //    {
        //        nama_customer = bje.customer;
        //        Console.WriteLine("Nama Customer\t\t : " + bje.customer);

        //    }
        //    else if(nama_mesin== "Huanglong")
        //    {
        //            nama_customer = huanglong.customer;
        //        Console.WriteLine("Nama Customer\t\t : " + huanglong.customer);

        //    }
        //}

        public void pemotongan()
        {
            bje bje = new bje();
            huanglong huanglong = new huanglong();
            ulang = true;
            while (ulang)
            {


                Console.WriteLine("");

                Console.WriteLine("\t\t\t  1. BJE");
                Console.WriteLine("\t\t\t  2. Huanglong");

                Console.Write("Mesin(1/2) \t\t : ");
                pilihan = int.Parse(Console.ReadLine());
                if (pilihan == 1)
                {
                    bje.produk();
                    nama_mesin = "BJE";
                    cek = 1;
                    ulang = false;
                }
                else if (pilihan == 2)
                {
                    huanglong.produk();
                    nama_mesin = "Huanglong";
                    cek = 2;
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

                if (cek == 1)
                {
                    nama_customer = bje.customer;

                }
                else if (cek == 2)
                {
                    nama_customer = huanglong.customer;

                }

            

        }

        public void jumlahproduksi()
        {
            Console.Write("Target Produksi\t\t : ");
            target = int.Parse(Console.ReadLine());

            Console.Write("Jumlah Produksi\t\t : ");
            selesai = int.Parse(Console.ReadLine());


            if (selesai==target)
            {
                harian = "Target Tercapai";

            }
            else if (selesai<target)
            {
                selesai = target - selesai;
                harian = "Produksi Kurang "+ selesai;
            }
            else if (selesai > target)
            {
                selesai = selesai - target;
                harian = "Produksi Telampaui " + selesai;
            }
        }


    }



    }

