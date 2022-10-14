using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Buku
    {
        public string penulis;
        public string judul;
        public int netto;

        public Buku(string penulis, string judul, int netto)
        {
            this.penulis = penulis;
            this.judul = judul;
            this.netto = netto;
        }
    }
}
