using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading File");
            Download();
            // ReadLine allows you to type into the console.
            Console.ReadLine();
        }

        static void Download() 
        {
            // Tasks are used as if you are handing a job to another person so that they will get on with that task whilst the main program continues with the rest of the program sequence.
            // In this example, it allows your 'helper' i.e. the task to do the sleep function and wait 3 seconds whilst allowing the main program to move on to ReadLine, thus allowing you to enter in the console whilst it is waiting.
            Task.Run( () =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Download Complete");
            });
            

        }
    }
}
