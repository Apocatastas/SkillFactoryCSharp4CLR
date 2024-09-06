using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
  
        int temp;

        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j < arr.GetUpperBound(1); j++)
            {
                for (int z = j; z < arr.GetUpperBound(1)+1; z++)
                {
                    if (arr[i, j] > arr[i, z])
                    {
                        temp = arr[i, j];
                        arr[i, j] = arr[i, z];
                        arr[i, z] = temp;
                    }
                }
            }


            
        }

        foreach (var item in arr)
        {
            Console.Write(item);
        }
        Console.ReadKey();
    }
        
   

}
