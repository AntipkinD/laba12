using System.Collections;
using System.Collections.Specialized;
internal class Program
{
    private static void Main(string[] args)
    {
        int n, d;
        bool prove;

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
        UralStars.Add(6, "Букин");
        UralStars.Add(1, "Полено");
        void WriteAll()
        {
            foreach (int i in UralStars)
            {
                Console.WriteLine(UralStars[n]);
            }
        }
            Console.WriteLine("Выберите действие: " +
            "1 - Вывод значения в соответствии с ключом" +
            "2 - Удаление значения в соответствии с ключом" +
            "3 - Вывод всех значений за исключением ключевого" +
            "4 - Удаление всех элементов");
        d = Convert.ToInt32(Console.ReadLine());
        switch (d)
        {
            case (1):
                n = Convert.ToInt32(Console.ReadLine());
                if (UralStars[n] == null)
                Console.WriteLine("Игрок не найден!");
                Console.WriteLine(UralStars[n]);
                break;
            case (2):
                n = Convert.ToInt32(Console.ReadLine());
                prove = UralStars.ContainsKey(n);
                if (prove == true)
                UralStars.Remove(n);
                else Console.WriteLine("Игрок не найден!");
                break;
            case (3):
                n = Convert.ToInt32(Console.ReadLine());
                prove = UralStars.ContainsKey(n);
                if (prove == true)
                {
                    UralStars.Remove(n);
                        WriteAll();
                }
                else Console.WriteLine("Игрок не найден!");
                break;
            case (4):
                WriteAll();
                UralStars.Clear();
                WriteAll();
                break;
        }
        
    }
}