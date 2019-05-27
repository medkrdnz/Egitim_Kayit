using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKayitLib
{
    public class Ogretmen :KendindenGuidliSınıf
    {
        public string OgretmenAdi { get; set; }

        public Ogretmen(string ogretmenAdi)
        {
            this.OgretmenAdi = ogretmenAdi;
        }

        public Ogretmen(string Id,string ogretmenAdi) :base(Id)
        {
            this.OgretmenAdi = ogretmenAdi;
        }
    }
}
