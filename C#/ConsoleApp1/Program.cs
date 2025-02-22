using System;
using System.Collections;
using System.Collections.Generic;

// Базовый класс Function и его наследники
public abstract class Function : IComparable<Function>, ICloneable
{
    public abstract double Calculate(double x);
    public abstract void DisplayInfo();

    public virtual int CompareTo(Function other)
    {
        if (other == null) return 1;
        if (this.GetType() == other.GetType())
        {
            return CompareToSameType(other);
        }
        else
        {
            return string.Compare(this.GetType().Name, other.GetType().Name, StringComparison.Ordinal);
        }
    }

    protected abstract int CompareToSameType(Function other);
    public abstract object Clone();
}

public class Line : Function
{
    public double a { get; set; }
    public double b { get; set; }

    public Line(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public override double Calculate(double x) => a * x + b;

    public override void DisplayInfo() => Console.WriteLine($"Прямая: y = {a}x + {b}");

    protected override int CompareToSameType(Function other)
    {
        if (other is Line otherLine)
        {
            return a.CompareTo(otherLine.a);
        }
        throw new ArgumentException("Invalid comparison.");
    }

    public override object Clone() => new Line(a, b);
}

public class Kub : Function
{
    public double a { get; set; }
    public double b { get; set; }
    public double c { get; set; }

    public Kub(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double Calculate(double x) => a * x * x + b * x + c;

    public override void DisplayInfo() => Console.WriteLine($"Куб: y = {a}x^2 + {b}x + {c}");

    protected override int CompareToSameType(Function other)
    {
        if (other is Kub otherKub)
        {
            return a.CompareTo(otherKub.a);
        }
        throw new ArgumentException("Invalid comparison.");
    }

    public override object Clone() => new Kub(a, b, c);
}

public class Hyperbola : Function
{
    public double a { get; set; }

    public Hyperbola(double a)
    {
        this.a = a;
    }

    public override double Calculate(double x)
    {
        if (x == 0) throw new ArgumentException("x cannot be zero.");
        return a / x;
    }

    public override void DisplayInfo() => Console.WriteLine($"Гипербола: y = {a}/x");

    protected override int CompareToSameType(Function other)
    {
        if (other is Hyperbola otherHyperbola)
        {
            return a.CompareTo(otherHyperbola.a);
        }
        throw new ArgumentException("Invalid comparison.");
    }

    public override object Clone() => new Hyperbola(a);
}

// Хеш-таблица для работы с Function
public class Hash
{
    private Dictionary<object, Function> data = new();

    public int Count => data.Count;

    public Function this[object key]
    {
        get
        {
            if (data.ContainsKey(key))
                return data[key];
            throw new KeyNotFoundException("Key not found.");
        }
        set
        {
            if (data.ContainsKey(key))
                data[key] = value;
            else
                throw new KeyNotFoundException("Key not found.");
        }
    }

    public void Add(object key, Function function) => data[key] = function;

    public void Remove(object key)
    {
        if (!data.Remove(key))
            throw new KeyNotFoundException("Key not found.");
    }

    public void Clear() => data.Clear();

    public Function Find(Function function)
    {
        foreach (var item in data.Values)
        {
            if (item.Equals(function))
                return item;
        }
        return null;
    }

    public IEnumerable<KeyValuePair<object, Function>> GetAll() => data;
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем список функций
        List<Function> functions = new List<Function>
        {
            new Line(2, 3),
            new Kub(1, -4, 5),
            new Hyperbola(10),
            new Line(1, 0),
            new Kub(2, 2, 2)
        };

        // Сортировка списка функций
        functions.Sort();

        Console.WriteLine("Сортированные функции:");
        double x = 2.0;
        foreach (var func in functions)
        {
            func.DisplayInfo();
            Console.WriteLine($"Значение в точке x = {x}: {func.Calculate(x)}");
            Console.WriteLine();
        }

        // Работа с хеш-таблицей
        Hash hashTable = new();
        hashTable.Add("Line1", new Line(2, 3));
        hashTable.Add("Kub1", new Kub(1, -4, 5));
        hashTable.Add("Hyperbola1", new Hyperbola(10));

        Console.WriteLine("Все функции в хеш-таблице:");
        foreach (var item in hashTable.GetAll())
        {
            Console.WriteLine($"Ключ: {item.Key}");
            item.Value.DisplayInfo();
            Console.WriteLine();
        }

        // Поиск функции
        Console.WriteLine("Поиск функции:");
        Function foundFunction = hashTable.Find(new Line(2, 3));
        if (foundFunction != null)
        {
            Console.WriteLine("Найдено:");
            foundFunction.DisplayInfo();
        }
        else
        {
            Console.WriteLine("Функция не найдена.");
        }
    }
}