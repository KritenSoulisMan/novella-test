using System;
using System.Threading;

class selectNachalo
{
    public static void m()
    {
        Console.Clear();
        help();
    }

    static void help()
    {
        Console.WriteLine("Каждый сделанный вами выбор будет влиять на сюжет.");
        Thread.Sleep(3000);
        Console.WriteLine("");
        Console.WriteLine("Для выбора действия напишите число которым оно пронумеровано.");
        Thread.Sleep(3000);
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Удачной игры!");
        Thread.Sleep(5000);
        Console.Clear();
        vibor();
    }

    static void vibor()
    {
        Console.Write("В");
        Thread.Sleep(200);
        Console.Write("ы");
        Thread.Sleep(200);
        Console.Write("б");
        Thread.Sleep(200);
        Console.Write("о");
        Thread.Sleep(200);
        Console.Write("р");
        Thread.Sleep(200);
        Console.Write(" ");
        Thread.Sleep(200);
        Console.Write("с");
        Thread.Sleep(200);
        Console.Write("ц");
        Thread.Sleep(200);
        Console.Write("е");
        Thread.Sleep(200);
        Console.Write("н");
        Thread.Sleep(200);
        Console.Write("а");
        Thread.Sleep(200);
        Console.Write("р");
        Thread.Sleep(200);
        Console.Write("и");
        Thread.Sleep(200);
        Console.Write("я");
        Thread.Sleep(200);
        Console.Write(".");
        Thread.Sleep(450);
        Console.Write(".");
        Thread.Sleep(850);
        Console.Write(".");
        Thread.Sleep(1350);
        Console.Clear();
        Random random = new Random();
        int rand = random.Next(1);
        switch (rand)
        {
            case 0:
                death.spawn();
                break;
            case 1:
                life.spawn();
                break;
        }
    }
}
