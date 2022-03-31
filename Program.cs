using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipotenus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci kenar uzunlugunu giriniz: ");
            int kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci kenar uzunlugunu giriniz: ");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            double hipotenus = Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2);
            Console.WriteLine("Hipotenüs: "+ hipotenus);
            Console.ReadKey();

        }
    }
}
