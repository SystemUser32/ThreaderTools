WriteLine("Starting...");
//Testing.EntryPoint();

Threader threader = new Threader();
Stopwatch watch = Stopwatch.StartNew();

Thread t1 = new Thread(threader.IncreaseCount);
Thread t2 = new Thread(threader.Helper);

t1.Start();
t2.Start();

//Testing behaviour of the main thread:
watch.Start();

int localCount = 0;

while(threader.exec)
{
    ForegroundColor = ConsoleColor.Yellow;
    localCount++;
    WriteLine($"Main thread iteration: {localCount}");
    if (localCount > 100)
        threader.exec = false;

    Thread.Sleep(threader.sleepTime);
}

watch.Stop();
WriteLine($"Main thread took {watch.ElapsedMilliseconds}ms");


