using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum
{
    public class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double GAJI() 
        {
            return GajiBulanan;
        }
    }
}
