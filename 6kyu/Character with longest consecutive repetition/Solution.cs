namespace Solution
{
  using System;
  using System.Linq;
  using System.Collections.Generic;
  
  public static class Kata
  {
      public static Tuple<char?, int> LongestRepetition(string input)
      {
          Tuple<char?, int> res = new Tuple<char?, int>(null, 0);
          if(!String.IsNullOrEmpty(input))
          {
            int i = 0;
            List<(char?, int)> list = new List<(char?, int)>();

            char? prev = null;
            foreach(var c in input)
            {
                if( c!=prev )
                {
                    prev = c;
                    i += 1;
                }
                list.Add((c,i));
            }

            var cg = from c in list
                        group c by c into gr
                        select (gr.First(), gr.Count());

            i = (from x in cg select x.Item2).Max();

            res = (from x in cg 
                   where x.Item2 == i 
                    select(new Tuple<char?, int>(x.Item1.Item1, x.Item2))).First();
          }
          return res;
      }
  }
}