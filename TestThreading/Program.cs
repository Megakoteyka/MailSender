using System;
using System.Threading;

namespace TestThreading
{
    class Program
    {
        private static readonly AutoResetEvent FactCompleteEvent = new AutoResetEvent(false);
        private static readonly AutoResetEvent SumCompleteEvent = new AutoResetEvent(false);

        private static readonly WaitHandle[] Events = { FactCompleteEvent, SumCompleteEvent };

        static void Main()
        {
            const int nFact = 27; // 27! еще влезает в decimal, а 28! - уже нет
            const int nSum = 1_000_000;


            Console.WriteLine("Threads:");
            new Thread(() => Fact(nFact)).Start();
            new Thread(() => Sum(nSum)).Start();

            if (!WaitHandle.WaitAll(Events, 5000))
                Console.WriteLine("Потоки не успели завершить работу за 5 секунд");


            Console.WriteLine("ThreadPool:");
            ThreadPool.QueueUserWorkItem(Fact, nFact);
            ThreadPool.QueueUserWorkItem(Sum, nSum);

            if (!WaitHandle.WaitAll(Events, 5000))
                Console.WriteLine("Потоки не успели завершить работу за 5 секунд");


            Console.WriteLine();
            Console.Write("Press any key for exit...");
            Console.ReadKey();
        }

        private static void Fact(object parameter) => Fact((int)parameter);
        private static void Fact(int n)
        {
            decimal result = 1;

            for (var i = 2; i <= n; i++)
                result *= i;

            Console.WriteLine($"Fact({n}) = {result}");

            FactCompleteEvent.Set();
        }

        private static void Sum(object parameter) => Sum((int)parameter);
        private static void Sum(int n)
        {
            decimal result = 0;

            for (var i = 0; i <= n; i++)
                result += i;

            Console.WriteLine($"Sum({n}) = {result}");

            SumCompleteEvent.Set();
        }
    }
}
