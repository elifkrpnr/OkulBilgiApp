using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulBilgiApp
{
    internal class OgrenciDers
    {
        public int Id { get; set; } 
        public int OgrenciId { get; set; }
        public int DersId { get; set; }

        public Ogrenci? Ogrenci { get; set; }
        public Ders? Ders { get; set; }
    }
}
