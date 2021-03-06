namespace ThreaderTools;

internal class Threader
{
    public int count = 0;
    public int limit = 100;
    public int sleepTime = 100; //Its fine at 100ms
    public bool exec = true;

    public void IncreaseCount() {
    
        Stopwatch watch = Stopwatch.StartNew();
        watch.Start();
        while(exec) {
            ForegroundColor = ConsoleColor.Red;
            count++;
            WriteLine($"\"Threader.IncreseCount\" iteration: {count}");

            if(count >= limit)
                exec = false;

            Thread.Sleep(sleepTime);
        }

        watch.Stop();
        WriteLine($"\"Threader.IncreaseCount\" took {watch.ElapsedMilliseconds}ms");

    }

    public void Helper() {

        Stopwatch watch = Stopwatch.StartNew();
        watch.Start();
        while (exec) {
            ForegroundColor = ConsoleColor.Blue;
            WriteLine($"Helper thread iteration: {count}");
            if (count > 100)
                exec = false;

            Thread.Sleep(sleepTime);
        }

        watch.Stop();
        WriteLine($"\"Threader.Helper\" took {watch.ElapsedMilliseconds}ms");

    }
}

