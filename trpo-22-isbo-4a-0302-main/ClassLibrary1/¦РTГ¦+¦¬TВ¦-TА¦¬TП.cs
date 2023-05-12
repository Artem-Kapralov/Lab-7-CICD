using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Аудитория
    {
        public string Название { get; }
        public Сотрудник Ответственный { get; }
        public uint Количество_посадочных_мест { get; }
        public uint Количество_окон { get; }
        public List<Оборудование> Оборудование { get; }

        public Аудитория(string название, Сотрудник ответственный, uint количество_посадочных_мест, uint количество_окон, List<Оборудование> оборудование)
        {
            this.Название = название;
            this.Ответственный = ответственный;
            this.Количество_посадочных_мест = количество_посадочных_мест;
            this.Количество_окон = количество_окон;
            this.Оборудование = оборудование;
        }
    }
}
