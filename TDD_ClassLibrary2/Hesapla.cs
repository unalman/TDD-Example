using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_ClassLibrary2
{
    public class Hesapla:IHesapla
    {
        public int Toplama(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }

        public int Cikarma(int s1, int s2)
        {
            int sonuc = s1 - s2;
            return sonuc;
        }
        public int Carpma(int s1, int s2)
        {
            int sonuc = s1 * s2;
            return sonuc;

        }
        public double Bolme(int s1, int s2)
        {
            double sonuc = s1 / s2;
            return sonuc;
        }
       

   
    }
}
