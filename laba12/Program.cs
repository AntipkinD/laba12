using System.Collections;
using System.Collections.Specialized;
internal class Program
{
    private static void Main(string[] args)
    {
        int n, d;
        bool prove;
        //создание и инициализация хэш-таблицы
        var UralStars = new Hashtable()
        {
            {10, "Зиновьев"},
            {13, "Вурхиз"},
            {7, "Волчков"},
            {18, "Тарасов"},
            {16, "Семипядов"},
            {5, "Нарышкин"},
            {9, "Слуцкий"},
            {99, "Почтисотнев"},
            {666, "Зверев"}
        };
        //дополнение хэш-таблицы
        UralStars.Add(6, "Букин");
        UralStars.Add(1, "Полено");
        //метод для вывода всех элементов коллекции разными сочетаниями: только ключ, только значение или все вместе
        void WriteAll(char deistv)
        {
            IDictionaryEnumerator R = UralStars.GetEnumerator();
            switch (deistv)
            {
                case ('k'):
                    while (R.MoveNext())
                    {
                        Console.Write($"{R.Entry.Key}; ");
                    }
                    break;
                case ('v'):
                    while (R.MoveNext())
                    {
                        Console.WriteLine($"{R.Entry.Value}; ");
                    }
                    break;
                case ('a'):
                    while (R.MoveNext())
                    {
                        Console.WriteLine($"{R.Entry.Key} - {R.Entry.Value}; ");
                    }
                    break;
            }
        }
        //метод для ввода пользователем ключа-определителя игрока, над которым будет совершено действие
        void WWod(string txt)
        {
            Console.WriteLine($"{txt}");
            n = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Выберите действие: " +
            "1 - Вывод значения в соответствии с ключом " +
            "2 - Удаление значения в соответствии с ключом " +
            "3 - Вывод всех значений за исключением ключевого " +
            "4 - Удаление всех элементов ");
        d = Convert.ToInt32(Console.ReadLine());
        switch (d)
        {
            case (1):
                WriteAll('k');
                WWod("Введите номер игрока, которого хотите увидеть");
                if (UralStars[n] == null)
                Console.WriteLine("Игрок не найден!");
                else
                Console.Write(UralStars[n]);
                break;
            case (2):
                WriteAll('a');
                WWod("Введмте номер игрока, которого хотите удалить");
                prove = UralStars.ContainsKey(n);
                if (prove == true)
                {
                    Console.WriteLine($"Игрок {UralStars[n]} удален");
                    UralStars.Remove(n);
                }
                else Console.WriteLine("Игрок не найден!");
                WriteAll('a');
                break;
            case (3):
                WriteAll('a');
                WWod("Введите номер игрока, которого хотите исключить");
                prove = UralStars.ContainsKey(n);
                if (prove == true)
                {
                    IDictionaryEnumerator N = UralStars.GetEnumerator();
                    while (N.MoveNext())
                    {
                        if (n == Convert.ToInt32(N.Entry.Key))
                        {
                            //Console.WriteLine($"Игрок {UralStars[n]} исключен");
                            N.MoveNext();
                        }
                        Console.WriteLine($"{N.Entry.Key} - {N.Entry.Value} ");
                    }
                }
                else Console.WriteLine("Игрок не найден!");
                break;
            case (4):
                WriteAll('v');
                UralStars.Clear();
                WriteAll('v');
                Console.WriteLine("Игроки удалены, никого не осталось...");
                break;
        }
        
    }
}