using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int positiveQuantity = 0;
        var arr = new int[15];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Please enter element number {0}: ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if (arr[i] > 0) { positiveQuantity++; };
        }
        Console.Write("\nARRAY: ");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\nPositive quantity: " + positiveQuantity);
    
        Console.ReadKey();
    }

}
