using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            sum();
            sumArray();
            sumList();
            
            var book = new Book("");
            book.AddGrade(99.9);
            book.AddGrade(70.86);
            book.AddGrade(17.05);
            book.AddGrade(105);
            book.AddGrade(351.05);

            var stats = book.showStats();
            Console.WriteLine($"Alta: {stats.High}, Baixa: {stats.Low}, Média:{stats.Average:N2}");

            
        }

        static void sum() 
        {
            double x = 15.3;
            double y = 22.6;
            double z = x + y;;

            Console.WriteLine($"A soma de {x} + {y} é igual a {z}.");
        }
 
        static void sumArray()
        {
            // console.log()
            var numbers = new[] { 12.05, 23.57, 54.39, -12 };
            var result = 0.0;

            foreach(var number in numbers)
            {
                result += number;
            };

            Console.WriteLine($"O resultado da Soma entre {numbers[0]} + {numbers[1]} + {numbers[2]} é igual a {result}");
        }

        static void sumList()
        {
            var grades = new List<double>() { 12.05, 23.57, 54.39 };
            grades.Add(17.9);

            var result = 0.0;
            foreach(var grade in grades)
            {
                result += grade;
            };
            var average = result /= grades.Count;

            Console.WriteLine($"O resultado da Soma de Array entre {grades[0]} + {grades[1]} + {grades[2]} + {grades[3]} é igual a {result}");
            Console.WriteLine($"A média entre os membros do Array é igual a {average:N2}");
        }   

    }
}
