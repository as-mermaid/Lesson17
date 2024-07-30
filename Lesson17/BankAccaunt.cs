using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    internal class BankAccaunt<T>
    {
        T Number { get; set; }
        double Balanse { get; set; }
        string Name { get; set; }

        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Number = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите значение текущего баланса");
            Balanse = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца аккаунта");
            Name = Console.ReadLine();
        }

        public string GetInfo()
        {
            return $"{Number} {Name} {Balanse}";
        }
    }
}
