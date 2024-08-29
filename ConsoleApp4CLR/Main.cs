using System;

class MainClass
{
    public static void Main(string[] args)
    {
        /*
         переменная A типа int меньше переменной B типа int,
        или переменная X типа double больше переменной Y типа double.

Внимание: для начала необходимо объявить переменные.
        Значение выражения положить в переменную C логического типа.
        Задавать значения для A, B, X и Y не нужно.
         */


        int a;
        int b;
        double x;
        double y;


        bool c = (a < b) | (x > y);
        Console.WriteLine(c);
        Console.ReadKey();


    }
}