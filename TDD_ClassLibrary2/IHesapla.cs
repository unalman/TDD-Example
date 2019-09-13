using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_ClassLibrary2
{
   public interface IHesapla
    {
        int Toplama(int s1, int s2);
        int Cikarma(int s1, int s2);
        int Carpma(int s1, int s2);
        double Bolme(int s1,int s2);
        
    }
}
