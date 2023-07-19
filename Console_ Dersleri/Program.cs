 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console__Dersleri.Model;

namespace Console__Dersleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int alt = 1;
            int ust = 63;
            int tahmin;
            int sayac = 0;
            Random rnd = new Random();
            int tutulan = rnd.Next(63) + 1;
        dnz:
            tahmin = (alt + ust) / 2;
            sayac++;
            if (tahmin == tutulan)
            {
                Console.Write("Tutulan= " + tutulan + "      Sayaç= " + sayac);
            }
            else
            {
                if (tutulan > tahmin)
                {
                    alt = tahmin;
                }
                else
                {
                    ust = tahmin;
                }
                goto dnz;
            }

            Console.ReadLine();
        }
    }
}

