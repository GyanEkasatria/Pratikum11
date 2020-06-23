using System;
using System.Collections.Generic;

namespace Praktikum
{
    class Program
    {
        static void Main(string[] args)
        {
            KaryawanTetap karyawanT = new KaryawanTetap();
            karyawanT.NIK  = "255-196-100";
            karyawanT.NAMA = " Oidipus";
            karyawanT.GajiBulanan = 3800000;

            KaryawanHarian karyawanH = new KaryawanHarian();
            karyawanH.NIK  = "168-192-109";
            karyawanH.NAMA = " Lokaste";
            karyawanH.JamKerja = 7;
            karyawanH.UpahperJam = 25000;

            Sales sales = new Sales();
            sales.NIK  = "316-666-911";
            sales.NAMA = " Sphinx";
            sales.JumlahPenjualan = 25;
            sales.Pendapatan = 30000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanT);
            listKaryawan.Add(karyawanH);
            listKaryawan.Add(sales);

            int Number = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, NAMA: {2}, GAJI: {3:N0}", Number, karyawan.NIK, karyawan.NAMA, karyawan.GAJI());
                Number++;
            }
            Console.ReadKey();
        }     
    }
 
}
