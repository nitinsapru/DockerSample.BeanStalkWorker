using System;
using System.Threading;

namespace DockerSample.BeanStalkWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<=10; i++)
            {
                Console.WriteLine($"This is the {i}th iteration.");
                Thread.Sleep(3000);
            }
        }
    }
}
