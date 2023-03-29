using System;

using System.Numerics;

namespace Solution{
    public static class Kata {
        public static BigInteger F(int n) {            
            BigInteger res = n;

            int a1 = 2;
            int a2 = 3;

            if (n == 1)
                return a1 - 1;
                
            if(n == 2)
                return a2 - 1;

            for (int i = 0 ; i < n - 2; i++)
            {
                a2+=a1;
                a1 = a2- a1;
            }

                   
           return a2 - 1;
        }
    }
}
