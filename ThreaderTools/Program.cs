WriteLine("Starting...");
//Testing.EntryPoint();

Threader threader = new Threader();

Thread t1 = new Thread(threader.IncreaseCount);
t1.Start();

threader.Helper();

//Testing the behaviour of the main thread:
//while (threader.exec)
//{
//    WriteLine($"Main thread iteration: {threader.count}");
//    if (threader.count > 100)
//        threader.exec = false;

//    Thread.Sleep(threader.sleepTime);//Not for serious purposes
//}
