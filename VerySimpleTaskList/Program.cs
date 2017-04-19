using System;

namespace VerySimpleTaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome World!");
            TaskManager manager = new TaskManager();
            manager.Run();
        }
    }
}
