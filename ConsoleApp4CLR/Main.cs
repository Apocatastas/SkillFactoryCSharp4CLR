using System;
using System.Xml.Linq;

class MainClass
{
    enum PetType 
    {
        кошка,
        рыбка,
        хомячок
    }


    public static void Main(string[] args)
    {

        (string Name, string Type, double Age, int NameCount) Pet;

        Console.Write("Введите имя: ");
        Pet.Name = Console.ReadLine();


        do
        {
            Console.Write("Введите тип (кошка, рыбка или хомячок): ");
            Pet.Type = Console.ReadLine();
        }
        while
           ((Convert.ToString(Pet.Type) != Convert.ToString(PetType.кошка)) &&
            (Convert.ToString(Pet.Type) != Convert.ToString(PetType.рыбка)) &&
            (Convert.ToString(Pet.Type) != Convert.ToString(PetType.хомячок)));


        Console.Write("Введите возраст с цифрами: ");
        Pet.Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Имя питомца: {0}", Pet.Name);
        Console.WriteLine("Тип питомца: {0}", Pet.Type);
        Console.WriteLine("Возраст питомца: {0}", Pet.Age);
        Console.WriteLine("Длина имени питомца: {0}", Pet.Name.Length);

        Console.ReadKey();

    }
        
   

}
