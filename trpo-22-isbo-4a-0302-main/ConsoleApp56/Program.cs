using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp56
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите название класса, который хотите создать: ");
                switch (Console.ReadLine())
                {
                    case "Занятие": UI.Print(ClassCreator.Занятие()); break;
                    case "Аудитория": UI.Print(ClassCreator.Аудитория()); break;
                    default: Console.WriteLine("Такой класс не существует"); break;
                }
            }
        }
    }
}
