using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите своё имя");

        var name = Console.ReadLine();
        int nameRevertedIndex = name.Length;
        char[] nameReverted = new char[nameRevertedIndex];

        foreach (var ch in name)
        {
            nameReverted[nameRevertedIndex - 1] = ch;
            nameRevertedIndex--;
        }

        Console.WriteLine("Ваше имя в обратном порядке: ");

        foreach (var chR in nameReverted)
        {
            Console.Write(chR + " ");
        }

        Console.ReadKey();

    }

}
