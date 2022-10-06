using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        //Создаем наш стэк
        HashSet<int> hs = new HashSet<int>();

        //Запускаем цикл по вводу чисел в стэк
        char key = 'д';
        do
        {
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());

            //Проверяем было ли число введено ранее
            if (hs.Contains(a)) Console.WriteLine("Число вводилось ранее");
            else hs.Add(a);

            Console.WriteLine("Продолжить? н/д");
            key = Console.ReadKey(true).KeyChar;
        } while (char.ToLower(key) == 'д');

        //Выводим все числа в консоль
        Console.WriteLine("Введеные числа:");
        foreach (int e in hs)
        Console.WriteLine($"{e} ");
        Console.ReadKey();
    }
}