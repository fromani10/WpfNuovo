using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNuovo.Controller
{
    internal static class NumeriPrimiController
    {
             public static Task<int> CalcoloAsincrono(int stop, int start=1)
        {
            return Task.Run(() => CalcoloSincrono(stop, start));

        }
        public static int CalcoloSincrono(int stop, int start = 1)
        {
            int contatore = 0;
            for (int i = start; i <= stop; i++)
            {
                if (isPrime(i)) contatore++;
            }
            return contatore;
        }
        private static bool isPrime(int n)
        {
            if (n == 1 || n == 2) return true;
            if (n <= 0 || n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
