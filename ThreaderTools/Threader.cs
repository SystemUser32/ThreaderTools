namespace ThreaderTools;

internal class Threader
{
    public int count = 0;
    public int limit = 100;
    public int sleepTime = 100; //Its fine at 100ms
    public bool exec = true;

    public void IncreaseCount() {
    
        while(exec) {
            count++;
            WriteLine($"\"Threader.IncreseCount\" iteration: {count}");

            if(count >= limit)
                exec = false;

            Thread.Sleep(sleepTime);
        }

    }
}

