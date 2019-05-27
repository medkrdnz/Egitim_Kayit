using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKayitLib
{
    public class Ders : KendindenGuidliSınıf
    {
        public string DersAdi { get; set; }

        public Ders(string dersAdi)
        {           
            this.DersAdi = dersAdi;
        }

        public Ders(string Id,string dersAdi) : base(Id)
        {
            this.DersAdi = dersAdi;
        }
    }
}
