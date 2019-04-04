using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    class RSA
    {
        static Random random = new Random();

        const int minPrime = 100;
        const int maxPrime = 999;

        public int p;
        public int q;
        public int n;
        public int m;
        public int e;
        public int d;

        public int GenerateRandomPrimeNumber()
        {
            int number = 0;
            int loop = 1000000;
            while (--loop > 0)
            {
                number = random.Next(minPrime, maxPrime);
                if (IsPrimeNumber(number))
                    return number;
            }
            throw new Exception("Can't found prime number");
        }

        public bool IsPrimeNumber(int number)
        {
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            int max = Convert.ToInt32(Math.Sqrt(number));
            for (int j = 3; j < max; j += 2)
            if (number % j == 0)
                return false;
            return true;
        }

        public int GCD (int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }

        public void GenerateP()
        {
            p = GenerateRandomPrimeNumber();
            CalcNumbers();
            e = d = 0;
        }

        public void GenerateQ()
        {
            q = GenerateRandomPrimeNumber();
            CalcNumbers();
            e = d = 0;
        }

        public void GenerateE()
        {
            int number;
            int loop = 1000;
            while(--loop > 0)
            {
                number = random.Next(minPrime, maxPrime);
                if(GCD(number,m) == 1)
                {
                    e = number;
                    return;
                }
            }
            throw new Exception("Can't found E");
        }

        public void GenerateD()
        {
            int start = 0;
            for (int j = 1; j < maxPrime * maxPrime; j ++)
            {
                start = (start + e)% m;
                if(start == 1)
                {
                    d = j;
                    return;
                }
            }
            throw new Exception("Can't found D");
        }

        public void CalcNumbers()
        {
            n = p * q;
            m = (p - 1) * (q - 1);
        }

        public int Power(int a, int b, int n) // a^b mod n
        {
            long res = 1;
            for (long j = 1; j <= b; j++)
            {
                res = (res * a) % n;
            }
            return (int)res;
        }
       
        public int Encrypt(int t, int e, int n)
        {
            return Power(t, e, n);
        }

        public int Decrypt(int c, int d, int n)
        {
            return Power(c, d, n);
        }
    }
}
