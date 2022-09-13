using System;

namespace produksi.Models
{
    class Program
    {
        static void Main(string[] args)

        {
            karyawan pegawai = new karyawan();
            karyawan waktu = new karyawan();
            mesin mesin = new mesin();



            pegawai.identitas();
            waktu.waktu();
            mesin.pemotongan();
            mesin.jumlahproduksi();



            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--------------------------- Laporan Produksi Harian Papercore ---------------------------");
            Console.WriteLine("Nama Operator\t\t : "+ pegawai.nama);
            Console.WriteLine("Shift\t\t\t : "+waktu.shift);
            Console.WriteLine("Nama Mesin\t\t : "+mesin.nama_mesin);
            Console.WriteLine("Nama Produk\t\t : " + mesin.nama_customer);
            Console.WriteLine("Target Produksi\t\t : "+mesin.target);
            Console.WriteLine("Produksi Hari ini\t : "+mesin.harian);
        }
    }
}
