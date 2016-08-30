using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGS
{
    class Program
    {
        static void Main(string[] args)
        {
            double banka =50, ogs = 30, gecisUcreti = 3, gecisSayisi = 0, limit = 20;

            while (true)//while (banka+ogs>=gecisUcreti)
            {
                if (banka + ogs < gecisUcreti)
                    break;
                //sonraki satırlar geçiş işlemleri için
                if (ogs < limit)
                {
                    if (banka >= limit)//bankada 20den fazla veya eşit kredi varsa ogs ye aktar
                    {
                        banka -= limit;
                        ogs += limit;
                    }
                    else//yoksa kalan miktarı aktar
                    {
                        ogs += banka;
                        banka = 0;
                    }
                }
                if (ogs >= gecisUcreti)
                {
                    gecisSayisi++;
                    ogs -= gecisUcreti;
                }
            }

            Console.WriteLine("Geciş Sayısı:{0}\nBanka:{1}\nOGS:{2}", gecisSayisi, banka, ogs);

            for (;true ; )
            {
                break;

            }

            Console.ReadLine();
        }
    }
}
