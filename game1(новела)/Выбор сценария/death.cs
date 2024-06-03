using System;
using System.Threading;

class death
{
    static public void spawn()
    {
        Console.WriteLine("В данный момент вы смотрите телевизор сидя на диване.");
        Console.WriteLine("");
        Thread.Sleep(3000);
        Console.WriteLine("Вы чувствуете предмет в левом кармане.");
        Console.WriteLine("");
        Console.WriteLine("");
        Thread.Sleep(2000);
        Console.WriteLine("1. Вытащить предмет из кармана.");
        Thread.Sleep(500);
        Console.WriteLine("");
        Console.WriteLine("2. Проигнорировать.");
        Console.WriteLine("");
        Thread.Sleep(500);
        Console.Write("Выберите действие: ");

        string выбор = Console.ReadLine();

        switch (выбор)
        {
            case "1":
                blocknot(); //Посмотрел в блокнот.
                break;
            case "2":
                nepomnu(); //Не смотрел.
                break;
        }
    }

    static public void blocknot()
    {
        Console.Clear();
        Console.WriteLine("Вы достали блокнот с записями.");
        Console.WriteLine("");
        Thread.Sleep(2000);
        Console.WriteLine("Вы решаете прочесть его.");
        Console.WriteLine("");
        Thread.Sleep(3000);
        Console.WriteLine("Обо мне:");
        Thread.Sleep(800);
        Console.WriteLine("Мне 27 лет.");
        Thread.Sleep(600);
        Console.WriteLine("Я живу в России в городе Искрад.");
        Thread.Sleep(1000);
        Console.WriteLine("У меня с 15 лет нет родителей.");
        Thread.Sleep(1000);
        Console.WriteLine("У меня есть психические отклонения:");
        Thread.Sleep(1000);
        Console.WriteLine("Нарколепсия, амнезия и апатия.");
        Console.WriteLine("");
        Thread.Sleep(1000);
        Console.WriteLine("");
        Console.WriteLine("1. Закрыть.");
        Thread.Sleep(500);
        Console.WriteLine("");
        Console.WriteLine("2. Читать дальше.");
        Console.WriteLine("");
        Thread.Sleep(500);
        Console.Write("Выберите действие: ");

        string выбор = Console.ReadLine();

        switch (выбор)
        {
            case "1":
                television(); //Телевизор интересней.
                break;
            case "2":
                newinfo(); //Читаем блокнот дальше.
                break;
        }
    }

    static public void nepomnu()
    {
        /*
        Проигноривал тот факт что в кармане лежит блокнот.
        */
    }

    static public void television()//Решил не читать дальше
    {
        /*
        Новости по телевиденью, но просмотр прерывает звонок в дверь, это Ева?










        */
    }

    static public void newinfo() //Продолжаем читать блокнот
    {
        /*
        Встреча с Евой.
        ----------------------------------------

        Вы выключаете телевизор и читаете дальше.

        С момента утери родителей за вами присматривал старый Домовладелец.
        
        У вас есть знакомая коллега, её имя Ева.

        С ней вы познакомились 7 лет назад.
        
        Вот как это было:

        Я шел через акууратно прибраные полупустые офисные кабины к торговому автомату.

        И увидел работника, спящего на рабочем месте.

        Остановившись и подумав про себя "Ещё одна жертва офисных переработок", я зашагал в сторону торгового автомата.

        Грохот работы торгового автомата потревожил сон сотрудника офиса.

        Силуэт окрикнул меня женским голосом.

        Девушка: Сколько сейчас времени?

        "Вставьте имя героя": 23:27

        Девушка: Чёрт, я уже должна была отправить отчёт для бухгалтерии.

        Подумав про себя "Ну терять мне уже нечего", я решаю ей помочь.

        "Вставьте имя героя": Нужна помощь?

        Девушка: Это было бы великолепно!

        Мы справляемся с работой в кротчайшие сроки.

        Девушка: Спасибо тебе огромное! Как тебя звать //это предложение в разработке// мой герой?

        "Вставьте имя героя": Вергилий. //вставьте сюда имя героя, которое выберет игрок или я хз

        Девушка: А меня Ева.

        Так я и познакомился с ней.























































        Она вам помогает с уборкой по квартире

        Console.WriteLine("Ева приходит к 14:00.");
        Console.WriteLine("");
        Thread.Sleep(800);
        Console.WriteLine("Вы решаете посмотреть на часы.");
        Thread.Sleep(1000);
        Console.WriteLine("Время: 13:55");
        Thread.Sleep(1000);


        





















        */
    }


}
