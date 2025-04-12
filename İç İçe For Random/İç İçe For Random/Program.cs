using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İç_İçe_For_Random
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rs = new Random();
            int rastgekolon;
            int rastgeadet;
            int rsayı;

            adım2:
            Console.Write("Kaç Kolonda Rastgele Sayı Üretmek İstiyorsunuz? : \t");
            rastgekolon = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (rastgekolon >= 10)
            {
                Console.WriteLine("En Fazla 9 Kadar Kolon Adeti Oluşturulabilirsiniz: \t");
                goto adım2;
            }

            adım:
            Console.Write("Kolon İçinde Kaç Adet Rastgele Sayı Üretmek İstiyorsunuz? : \t");
            rastgeadet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            if (rastgeadet >= 10)
            {
                Console.WriteLine("En Fazla 9 Kadar Sayı Adeti Oluşturulabilirsiniz: \t");
                goto adım;
            }

            Console.WriteLine();

            for (int i = 0; i < rastgekolon; i++)
            {
                Console.WriteLine($"----- {i + 1}.Kolon --------");

                Console.WriteLine();

                int ilksayı, ikincisayı;

                Console.Write($"{i + 1}.Kolonda Sayı Üretmek İçin En Düşük Degeri Girin? : \t");
                ilksayı = Convert.ToInt32(Console.ReadLine());

                Console.Write($"{i + 1}.Kolonda Sayı Üretmek İçin En Yüksek Degeri Girin? : \t");
                ikincisayı = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                for (int j = 0; j < rastgeadet; j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    rsayı = rs.Next(ilksayı, ikincisayı);

                    Console.WriteLine($"{i + 1}.Kolonun {j + 1}.Rastgele Sayısı : {rsayı}");
                }

                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
