// Приветствие конкретного пользователя, например: Elvis

Console.WriteLine("Введите ваше имя");

string username = Console.ReadLine();

if(username.ToLower() == "elvis")

{
    Console.WriteLine("YoooHoo! It's Elvis!");
}
    
    else

    {
        Console.Write("Hello,");
        Console.Write(username);
        Console.WriteLine("!");
    }
