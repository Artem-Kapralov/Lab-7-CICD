using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp56
{
    internal static class UI
    {
        public static void Print(Занятие занятие)
        {
            Console.WriteLine($"Дата: {занятие.Date.ToLongDateString()}");
            Print(занятие.Дисциплина);
            Print(занятие.Сотрудник);
            Print(занятие.Аудитория);
            Print(занятие.Группа);
            Print(занятие.Пара);
            Print(занятие.Вид);

        }
        public static void Print(Аудитория аудитория)
        {
            Console.WriteLine($"Название: {аудитория.Название}");
            Console.WriteLine($"Ответственный: {аудитория.Ответственный}");
            Console.WriteLine($"Количество посадочных мест: {аудитория.Количество_посадочных_мест}");
            Console.WriteLine($"Количество окон: {аудитория.Количество_окон}");
            Console.WriteLine($"Количество оборудования: {аудитория.Оборудование.Count}");
            аудитория.Оборудование.ForEach(o => Print(o));
        }
        public static void Print(Сотрудник сотрудник)
        {

        }
        public static void Print(Оборудование оборудование)
        {

        }

        public static void Print(Вид вид)
        {

        }
        public static void Print(Группа группа)
        {

        }

        public static void Print(Дисциплина дисциплина)
        {

        }

        public static void Print(Пара пара)
        {

        }
    }
}
