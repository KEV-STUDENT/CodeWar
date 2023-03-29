using System;

using System.Numerics;

namespace Solution{
    public static class Kata {
        public static bool F(int n) {
            Console.WriteLine(n);
            int x = 0;
            int len = (int)Math.Log10(n)+1;
            int tmp = n;

            for(int i = 0; i < len; i++)
            {                             
                x += (int)Math.Pow(tmp%10,len);
                tmp = (int)tmp/10;
            }

            Console.WriteLine("{0} - {1}: {2}", n, x, n == x);
            return n == x;            
        }
    }
}
