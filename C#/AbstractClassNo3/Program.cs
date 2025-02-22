using System;

class Program
{
    static void Main(string[] args)
    {
        // Создание коллекций
        var collection1 = new MyNewCollection("Коллекция1");
        var collection2 = new MyNewCollection("Коллекция2");

        // Создание журналов
        var journal1 = new Journal();
        var journal2 = new Journal();

        // Подписка на события
        collection1.CollectionCountChanged += journal1.AddEntry;
        collection1.CollectionReferenceChanged += journal1.AddEntry;

        collection1.CollectionReferenceChanged += journal2.AddEntry;
        collection2.CollectionReferenceChanged += journal2.AddEntry;

        Console.WriteLine("Внесение изменений в коллекции 1:");
        collection1.Add("Ключ1", "Значение1");
        collection1.Add("Ключ2", "Значение2");

        Console.WriteLine("\nВнесение изменений в коллекции 2:");
        collection2.Add("КлючA", "ЗначениеA");
        collection2.Add("КлючB", "ЗначениеB");

        Console.WriteLine("\nУдаление элементов из коллекций:");
        collection1.Remove("Ключ1");
        collection2.Remove("КлючA");

        Console.WriteLine("\nОбновление значений в коллекциях:");
        collection1["Ключ2"] = "НовоеЗначение2";
        collection2["КлючB"] = "НовоеЗначениеB";

        Console.WriteLine("\nЖурнал 1 (Изменения коллекции 1):");
        Console.WriteLine(journal1);

        Console.WriteLine("\nЖурнал 2 (Изменения коллекций 1 и 2):");
        Console.WriteLine(journal2);
    }
}
