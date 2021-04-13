using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman3307
{
    class Class1
    {
        public class Karyawan
        {
            public int identitas;
            public string nama;
            public int gaji;
            public Karyawan(int nik, string name, int gajibulanan)
            {

                identitas = nik;
                nama = name;
                gaji = gajibulanan;
            }
        }
    }
}
