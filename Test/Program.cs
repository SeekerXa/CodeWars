// See https://aka.ms/new-console-template for more information


using System.Text;

public class Dinglemouse
{
    public static int CountDeafRats1(string town)
    {
        var rats = town.Replace(" ", "").Split('P');
        var leftCount = rats[0].Where((x, i) => i % 2 == 1).Count(x => x == '~');
        var rightCount = rats[1].Where((x, i) => i % 2 == 0).Count(x => x == '~');
        return leftCount + rightCount;
    }


    public static int CountDeafRats(string town)
    {
        return town
                .Replace(" ", "")
                .Where((x, i) => i % 2 == 0)
                .Count(x => x == 'O');
    }

    static void Main()
    {
          

        string ex1 = "~O~O~O~O";
        string ex2 = "P O~ O~ ~O O~";
        string ex3 = "~O~O~O~OP~O~OO~";
        CountDeafRats(ex2);
        CountDeafRats1(ex2);
}