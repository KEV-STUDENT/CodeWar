using System;

namespace Solution{
    public static class Kata {
        public static string ToCamelCase(string str)
        {
            string[] words = str.Split('-','_');
            str = words[0];
            for(int i = 1 ; i < words.Length; i++)
            {
                str += words[i].ToUpper();
            }
            return str;
        }
    }
}