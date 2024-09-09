using System;
using System.Xml.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
       //     Необходимо разработать методику анкетирования пользователей.
       //     Требуется сохранять информацию: об имени пользователя, фамилии,
       //     логине, длине логина, наличии/ отсутствии у пользователя питомца,
       //     возрасте пользователя, трех любимых цветах пользователя.



        (string FirstName, string LastName, string Login, int LoginLength, bool IsHasPet, int Age, string[] FavColors ) User;

        Console.Write("Введите имя: ");
        User.FirstName = Console.ReadLine();
        Console.Write("Введите фамилию: ");
        User.LastName = Console.ReadLine();
        Console.Write("Введите логин: ");
        User.Login = Console.ReadLine();
        User.LoginLength = User.Login.Length;
        Console.Write("Есть ли у вас животные (Да/Нет): ");
        var pets = Console.ReadLine();
        if (Convert.ToString(pets) == "Да")
            {
            User.IsHasPet = true;
            }

        else
            {
            User.IsHasPet = false;
            }

        Console.Write("Введите возраст: ");
        User.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите ваши любимые три цвета\n");
        User.FavColors = new string[3];
        Console.Write("#1: ");
        User.FavColors[0] = Console.ReadLine();
        Console.Write("#2: ");
        User.FavColors[1] = Console.ReadLine();
        Console.Write("#3: ");
        User.FavColors[2] = Console.ReadLine();



        Console.ReadKey();

    }
        
   

}
