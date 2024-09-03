using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

        int sum = 0;

        Console.WriteLine("Array: ");
        foreach (var item in arr)
            {
            sum = sum + item;
            Console.Write(item + " ");
            }

        Console.WriteLine("\nSum: " + sum);
        Console.ReadKey();
    }

}
