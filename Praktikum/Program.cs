using System;
using System.Collections.Generic;

namespace Praktikum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Karyawan> listKaryawan = new List<Karyawan>();
            void tampilKaryawan()
            {
                int Number = 1;
                foreach (Karyawan karyawan in listKaryawan)
                {
                    Console.WriteLine(" {0}. NIK: {1}, NAMA: {2}, GAJI: {3}, {4}", Number, karyawan.NIK, karyawan.NAMA, karyawan.GAJI(), karyawan.JenisKaryawan);
                    Number++;
                }
            }
            void create_KTetap (string nama, string nik, double gajibulanan, string krywn)
            {
                listKaryawan.Add (new KaryawanTetap { NAMA = nama, NIK = nik, GajiBulanan = gajibulanan, JenisKaryawan = krywn });
            }
            void create_KHarian (string nama, string nik, double jamkerja, int upahpj, string krywn)
            {
                listKaryawan.Add(new KaryawanHarian { NAMA = nama, NIK = nik, JamKerja = jamkerja, UpahperJam = upahpj, JenisKaryawan = krywn });
            }
            void create_Sales ( string nama, string nik, double penjualan, double pendapatan, string krywn)
            {
                listKaryawan.Add(new Sales { NAMA = nama, NIK = nik, JumlahPenjualan = penjualan, Pendapatan = pendapatan, JenisKaryawan = krywn });
            }
            void delete_K()
            {
                int n = 1;
                int jumlah_karyawan = 0;
                foreach (Karyawan karyawan in listKaryawan)
                {
                    Console.WriteLine("{0}. Nik: {1}", n, karyawan.NIK);
                    n++;
                    jumlah_karyawan += 1;
                }
                Console.WriteLine();
                Console.Write("Pilih Data Yang Ingin Dihapus [1-");
                Console.Write(jumlah_karyawan);
                Console.Write("] : ");
                int index_nik = int.Parse(Console.ReadLine());
                index_nik = index_nik - 1;

                listKaryawan.RemoveAt(index_nik);
                Console.WriteLine();
                Console.WriteLine("Data Berhasil Dihapus ");
                Console.WriteLine();
                Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
            }

            bool keluar = false;
            while (keluar == false)
            {
                Console.Clear();
                Console.WriteLine("\tPilih Menu : \n");
                Console.WriteLine("\t1. Tambah Data");
                Console.WriteLine("\t2. Hapus Data");
                Console.WriteLine("\t3. Tampilkan Data");
                Console.WriteLine("\t4. Exit");
                Console.WriteLine();
                Console.Write("Pilihan [1..4] = ");
                int pilih = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();

                if (pilih < 1 || pilih > 4)
                {
                    Console.WriteLine("Pilihan tidak tersedia");
                }
                else if (pilih == 1)
                {
                    Console.WriteLine("Tambah Data Karyawan");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine();
                    Console.Write("Jenis Karyawan:\n 1. Karyawan Tetap\n 2. Karyawan Harian\n 3. Sales\n Pilihan [1..3] = ");
                    int pilih1 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (pilih1 == 1)
                    {
                        Console.Write("\tNIK = ");
                        string nik = Console.ReadLine();
                        Console.Write("\tNAMA = ");
                        string nama = Console.ReadLine();
                        Console.Write("\tGaji Bulanan = ");
                        double gajibulanan = int.Parse(Console.ReadLine());
                        string krywn = "Karyawan Tetap";

                        create_KTetap(nama, nik, gajibulanan, krywn);
                    }
                    else if (pilih == 2)
                    {
                        Console.Write("\tNIK = ");
                        string nik = Console.ReadLine();
                        Console.Write("\tNAMA = ");
                        string nama = Console.ReadLine();
                        Console.Write("\tJam Kerja = ");
                        int jamkerja = int.Parse(Console.ReadLine());
                        Console.Write("Upah Per Jam = ");
                        int upah = int.Parse(Console.ReadLine());
                        string krywn = "Karyawan Harian";

                        create_KHarian(nama, nik, jamkerja,upah, krywn);
                    }
                    else if (pilih1 == 3)
                    {

                        Console.Write("tNIK = ");
                        string nik = Console.ReadLine();
                        Console.Write("\tNAMA = ");
                        string nama = Console.ReadLine();
                        Console.Write("\tPenjualan = ");
                        int jumlahjual = int.Parse(Console.ReadLine());
                        Console.Write("\tKomisi = ");
                        int komisi = int.Parse(Console.ReadLine());
                        string krywn = "Sales";

                        create_Sales(nama, nik, jumlahjual, komisi, krywn);
                    }
                    else
                    {
                        Console.WriteLine("Pilihan tidak tersedia");
                    }
                    Console.WriteLine();
                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
                }
                else if (pilih == 2)
                {
                    delete_K();
                }
                else if (pilih == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Data Karyawan :");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine();
                    tampilKaryawan();
                    Console.WriteLine("\nTekan Enter Untuk Kembali");
                }
                else if (pilih == 4)
                {
                    keluar = true;
                }
                Console.ReadLine();
            }
        }
    }
}
