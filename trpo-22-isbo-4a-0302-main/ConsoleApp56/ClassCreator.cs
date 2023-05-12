using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp56
{
    internal static class ClassCreator
    {
        public static Занятие Занятие()
        {

            Дисциплина дисциплина = Дисциплина();
            Сотрудник сотрудник = Сотрудник();
            Аудитория аудитория = Аудитория();
            Группа группа = Группа();
            Пара пара = Пара();
            Вид вид = Вид();


            Console.WriteLine();

            Console.WriteLine("Введите дату ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                return new Занятие(
                 дисциплина,
                 сотрудник,
                 аудитория,
                 группа,
                 пара,
                 вид,
                 date);
            else
                return new Занятие(
                дисциплина,
                сотрудник,
                аудитория,
                группа,
                пара,
                вид);
        }
        public static Дисциплина Дисциплина()
        {
            return new Дисциплина();
        }
        public static Аудитория Аудитория()
        {
            Console.WriteLine("Введите название: ");
            string название = Console.ReadLine();
            Console.WriteLine("Введите количество посадочных мест: ");
            uint количество_посадочных_мест = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество окон: ");
            uint количество_окон = uint.Parse(Console.ReadLine());
            List<Оборудование> оборудование = new List<Оборудование>();
            Console.WriteLine("Введите количество оборудования: ");
            uint количествоОборудования = uint.Parse(Console.ReadLine());

            for (int i = 0; i < количествоОборудования; i++)
            {
                оборудование.Add(Оборудование());
            }
            return new Аудитория(название, Сотрудник(), количество_посадочных_мест, количество_окон, оборудование);
        }
        public static Сотрудник Сотрудник()
        {
            return new Сотрудник();
        }
        public static Оборудование Оборудование()
        {
            return new Оборудование();
        }
        public static Группа Группа()
        {
            return new Группа();
        }
        public static Пара Пара()
        {
            return new Пара();
        }
        public static Вид Вид()
        {
            return new Вид();
        }
    }
}
