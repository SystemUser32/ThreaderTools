namespace ThreaderTools;

internal class Testing
{
    //May be used as a "main" method to be called from Program.cs
    public static void EntryPoint() {
        Testing testing = new Testing();
        //testing.RunNumberSquaring();
        testing.RunCharParsing();
    }

    public void RunNumberSquaring(long min = 1, long max = 4000000) {

        Stopwatch watch = Stopwatch.StartNew();
        watch.Start();

        IEnumerable<int> numbers = Enumerable.Range(unchecked((int)min), unchecked((int)max));
        var squares = numbers.Select(number => number * number).ToArray();

        watch.Stop();
        WriteLine($"\"RunNumberSquaring\" took {watch.ElapsedMilliseconds}ms");

    }

    public void RunCharParsing(long max = 4000000) {

        Stopwatch watch = Stopwatch.StartNew();
        watch.Start();

        int testNum;

        List<string> li = new List<string>();

        for(long i = 1; i <= max; i++)
        {
            li.Add("0");
        }

        foreach(string i in li)
        {
            testNum = Int32.Parse(i);
        }

        watch.Stop();
        WriteLine($"\"RunCharParsing\" took {watch.ElapsedMilliseconds}ms");

    }
}

