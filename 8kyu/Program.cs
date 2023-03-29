class Program
{
    private static void Main(string[] args)
    {
        string str = "1234567890";

        string res = string.Concat(Enumerable.Repeat("X",str.Length-4).Append(str.Substring(str.Length-4)));
        //string res = string.Concat(Enumerable.Repeat("X",str.Length-4));//, str.Substring(str.Length-4));
        System.Console.WriteLine(res);
        var i = Enumerable.Range(3,7).Where(s=>s%3==0 || s%5==0).Sum();
        //foreach(var i in Enumerable.Range(3,8).Where(s=>s%3==0 || s%5==0))
            System.Console.WriteLine(i);
    }
}