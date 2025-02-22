using ClassMoney;

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта Money
        Money money1 = new Money(10, 234);
        Console.WriteLine("Созданный объект:");
        money1.PrintInfo();

        #region UnarnOper
        // Унарные операции
        Console.WriteLine("Унарные операции:");

        ++money1; // добавление копейки
        Console.WriteLine("После ++money1:");
        money1.PrintInfo();

        --money1; // вычитание копейки
        Console.WriteLine("После --money1:");
        money1.PrintInfo();
        #endregion UnarnOper

        #region Privedenie
        // Приведение типов
        Console.WriteLine("Приведение типов:");

        int rubles = (int)money1; // явное приведение к int
        Console.WriteLine($"Рубли (явное приведение к int): {rubles}");

        double kopeksFraction = money1; // неявное приведение к double
        Console.WriteLine($"Копейки (неявное приведение к double): {kopeksFraction}");
        #endregion Privedenie

        #region BinarnOper
        // Бинарные операции
        Console.WriteLine("\nБинарные операции:");

        // Добавляем 50 копеек к объекту money1
        Money updatedMoney = Money.AddKopeks(money1, 50);
        Console.WriteLine("После добавления 50 копеек:");
        updatedMoney.PrintInfo();

        Money money2 = money1 + 75; // добавление копеек к объекту
        Console.WriteLine("После money1 + 75 копеек:");
        money2.PrintInfo();

        Money money3 = money2 - 150; // вычитание копеек из объекта
        Console.WriteLine("После money2 - 150 копеек:");
        money3.PrintInfo();
        #endregion BinarnOper

        // Вывод количества созданных объектов
        Console.WriteLine($"Количество созданных объектов: {Money.GetObjectCount()}");

        // Создание массива с помощью конструктора без параметров
        MoneyArray emptyArray = new MoneyArray();
        Console.WriteLine("\nПустой массив:");
        try
        {
            emptyArray.PrintArray();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Создание массива с помощью конструктора с параметрами (случайные значения)
        MoneyArray randomArray = new MoneyArray(5);
        Console.WriteLine("\nМассив со случайными значениями:");
        randomArray.PrintArray();

        // Поиск минимального значения в случайном массиве
        Money minRandom = randomArray.FindMinimum();
        Console.WriteLine("Минимальное значение в случайном массиве:");
        minRandom.PrintInfo();

        // Создание массива с помощью конструктора с пользовательским вводом
        MoneyArray userArray = new MoneyArray(3, true);
        Console.WriteLine("\nМассив, заполненный пользователем:");
        userArray.PrintArray();

        // Поиск минимального значения в пользовательском массиве
        Money minUser = userArray.FindMinimum();
        Console.WriteLine("Минимальное значение в пользовательском массиве:");
        minUser.PrintInfo();

        // Подсчет количества созданных объектов Money
        Console.WriteLine($"Количество созданных объектов Money: {Money.GetObjectCount()}");
    }
}
