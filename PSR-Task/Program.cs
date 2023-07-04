using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PSR_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start all tasks");
            Console.ReadKey();

            Console.Clear();

            Task tarea1 = Task.Run(() => Hilo1());
            Task tarea2 = Task.Run(() => Hilo2());
            Task tarea3 = Task.Run(() => Hilo3());

            Task.WaitAll(tarea1, tarea2, tarea3);

            Console.WriteLine("\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░" +
                "\n\n>>>Tasks completed successfully." + 
                "\n\nPress any key to close.");
            Console.ReadKey();
        }

        static void Hilo1()
        {
            Random rnd = new Random();
            
            int vueltas = rnd.Next(1, 11);

            for (int i = 0; i < vueltas; i++)
            {
                Console.WriteLine($"Thread 1, round {i}");
                Thread.Sleep(1000);
            }
        }

        static void Hilo2()
        {
            Random rnd = new Random();
            
            int vueltas = rnd.Next(1, 11);

            for (int i = 0; i < vueltas; i++)
            {
                Console.WriteLine($"Thread 2, round {i}");
                Thread.Sleep(2000);
            }
        }

        static void Hilo3()
        {
            Random rnd = new Random();
            
            int vueltas = rnd.Next(1, 11);

            for (int i = 0; i < vueltas; i++)
            {
                Console.WriteLine($"Thread 3, round {i}");
                Thread.Sleep(3000);
            }
        }
    }
}
