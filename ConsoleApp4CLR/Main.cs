﻿using System;
using System.Xml.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
       //     Необходимо разработать методику анкетирования пользователей.
       //     Требуется сохранять информацию: об имени пользователя, фамилии,
       //     логине, длине логина, наличии/ отсутствии у пользователя питомца,
       //     возрасте пользователя, трех любимых цветах пользователя.



        (string FirstName, string LastName, string Login, int LoginLength, bool IsHasPet, int Age, int[] FavColors ) User;

        Console.Write("Введите имя: ");
        User.FirstName = Console.ReadLine();
        Console.Write("Введите фамилию: ");
        User.LastName = Console.ReadLine();
        Console.Write("Введите логин: ");
        User.Login = Console.ReadLine();


        Console.ReadKey();

    }
        
   

}
