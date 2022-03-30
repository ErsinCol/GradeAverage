using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matematik notu: ");
            int matematik= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fizik: ");
            int fizik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kimya: ");
            int kimya = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Türkçe notu: ");
            int turkce = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tarih notu: ");
            int tarih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Müzik notu: ");
            int muzik = Convert.ToInt32(Console.ReadLine());
            int sonuc=matematik+fizik+kimya+turkce+tarih+muzik;
            double ortalama = sonuc / 6.0;
            Console.WriteLine("Not ortalaması: "+Math.Round(ortalama,2));
            Console.ReadKey();
            
        }
    }
}
