using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum
{
    public class KaryawanHarian : Karyawan
    {
        public double UpahperJam { get; set; }
        public double JamKerja { get; set; }
        public override double GAJI()
        {
            return UpahperJam * JamKerja;
        }
    }
}
