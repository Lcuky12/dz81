using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wallet = 0;
            
            Queue<int> customers = new Queue<int>();
            AddCustomers(customers);
            Serve(wallet, customers);

            Console.WriteLine("Клиенты все обслужены");
            Console.ReadKey();
        }

        static void AddCustomers(Queue<int> customers)
        {
            customers.Enqueue(5000);
            customers.Enqueue(350);
            customers.Enqueue(400);
            customers.Enqueue(300);

        }
 
        static void Serve(int wallet,Queue<int> customers)
        {
            while (customers.Count > 0)
            {
                Console.WriteLine("Была покупка на сумму" + customers.Peek());
                wallet += customers.Dequeue();
                Console.WriteLine($"В кассе:{wallet} руб.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
