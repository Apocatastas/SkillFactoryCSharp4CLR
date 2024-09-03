using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

        bool isSorted = false; // if there was a change, then not true
        int buff = 0; //changing buffer

        Console.WriteLine("UNSORTED:");
        for (int i = 0; i < arr.Length; i++) //printing
        {
            Console.Write(arr[i] + " ");
        }

        do
        {
            isSorted = true; //if there's no change, then cycle will break
            for (int i = 0; i < arr.Length-1; i++) //sorting
            {
                if (arr[i] > arr[i + 1])
                { //change places
                    buff = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = buff;
                    isSorted = false; //if there's a change, then we need to check again
                }

            }
        }
        while (isSorted == false);

        Console.WriteLine("\nSORTED:");
        for (int i = 0; i < arr.Length; i++) //printing
        {
            Console.Write(arr[i] + " ");
        }

        Console.ReadKey();
    }

}
