using System;
using System.Collections.Generic;
using ExercicioHashSet.Entities;

namespace ExercicioHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> set = new HashSet<Student>();

            Console.Write("How many students for couse A? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i<n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(new Student { Id = id });
            }

            Console.Write("How many students for couse B? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(new Student { Id = id });
            }

            Console.Write("How many students for couse C? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                set.Add(new Student { Id = id });
            }

            Console.WriteLine();
            Console.WriteLine("Total students: " + set.Count);
        }
    }
}
