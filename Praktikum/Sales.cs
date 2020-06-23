using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum
{
    public class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Pendapatan { get; set; }
        public override double GAJI()
        {
            return JumlahPenjualan * Pendapatan;
        }
    }
}
