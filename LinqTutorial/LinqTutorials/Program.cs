using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1Result = LinqTasks.Task1();
            Console.WriteLine("Task 1:");
            foreach (var emp in task1Result) { Console.WriteLine(emp); }
            
            var task2Result = LinqTasks.Task2();
            Console.WriteLine("Task 2:");
            foreach (var emp in task2Result) { Console.WriteLine(emp); }
            
            var task3Result = LinqTasks.Task3();
            Console.WriteLine("Task 3:");
            Console.WriteLine(task3Result);
            
            var task4Result = LinqTasks.Task4();
            Console.WriteLine("Task 4:");
            foreach (var emp in task4Result) { Console.WriteLine(emp); }
            
            var task5Result = LinqTasks.Task5();
            Console.WriteLine("Task 5:");
            foreach (var item in task5Result) { Console.WriteLine(item); }
            
            var task6Result = LinqTasks.Task6();
            Console.WriteLine("Task 6:");
            foreach (var item in task6Result) { Console.WriteLine(item); }
            
            var task7Result = LinqTasks.Task7();
            Console.WriteLine("Task 7:");
            foreach (var item in task7Result) { Console.WriteLine(item); }
            
            var task8Result = LinqTasks.Task8();
            Console.WriteLine("Task 8:");
            Console.WriteLine(task8Result);
            
            var task9Result = LinqTasks.Task9();
            Console.WriteLine("Task 9:");
            Console.WriteLine(task9Result);
            
            var task10Result = LinqTasks.Task10();
            Console.WriteLine("Task 10:");
            foreach (var item in task10Result) { Console.WriteLine(item); }
            
            var task11Result = LinqTasks.Task11();
            Console.WriteLine("Task 11:");
            foreach (var item in task11Result) { Console.WriteLine(item); }
            
            var task12Result = LinqTasks.Task12();
            Console.WriteLine("Task 12:");
            foreach (var emp in task12Result) { Console.WriteLine(emp); }
            
            var task13Result = LinqTasks.Task13(new int[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 });
            Console.WriteLine("Task 13:");
            Console.WriteLine(task13Result);
            
            var task14Result = LinqTasks.Task14();
            Console.WriteLine("Task 14:");
            foreach (var dept in task14Result) { Console.WriteLine($"{dept.Dname} ({dept.Deptno})"); }
        }
    }
}
