using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    // https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit
    public class Занятие
    {
        public DateTime Date { get; }
        public Дисциплина Дисциплина { get; }
        public Сотрудник Сотрудник { get; }
        public Аудитория Аудитория { get; }
        public Группа Группа { get; }
        public Пара Пара { get; }
        public Вид Вид { get; }

        public Занятие(Дисциплина дисциплина, Сотрудник сотрудник, Аудитория аудитория, Группа группа, Пара пара, Вид вид, DateTime? date = null)
        {

            this.Date = date ?? DateTime.Today;
            this.Дисциплина = дисциплина;
            this.Сотрудник = Сотрудник;
            this.Аудитория = аудитория;
            this.Группа = группа;
            this.Пара = пара;
            this.Вид = вид;

        }
    }
}
