using System;
using System.Collections.Generic;

public abstract class Function : IComparable<Function>, ICloneable
{
    // Абстрактный метод для вычисления значения функции в точке x
    public abstract double Calculate(double x);

    // Абстрактный метод для вывода информации о функции
    public abstract void DisplayInfo();

    // Реализация IComparable для сортировки по коэффициенту a
    public virtual int CompareTo(Function other)
    {
        // Универсальное поведение для сравнения функций разных типов
        if (other == null) return 1;

        if (this.GetType() == other.GetType())
        {
            // Если функции одного типа, используем соответствующую реализацию
            return CompareToSameType(other);
        }
        else
        {
            // Для функций разных типов сортируем по имени типа
            return string.Compare(this.GetType().Name, other.GetType().Name, StringComparison.Ordinal);
        }
    }

    // Метод для сравнения объектов одного типа
    protected abstract int CompareToSameType(Function other);

    // Реализация ICloneable для клонирования объекта
    public abstract object Clone();
}

// Производный класс Line: y = ax + b
public class Line : Function
{
    public double a { get; set; }
    public double b { get; set; }

    public Line(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public override double Calculate(double x)
    {
        return a * x + b;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Прямая: y = {a}x + {b}");
    }

    protected override int CompareToSameType(Function other)
    {
        if (other is Line otherLine)
        {
            return a.CompareTo(otherLine.a); // Сортировка по коэффициенту a
        }
        throw new ArgumentException("Сравнение с функцией, не являющейся линейной, не поддерживается.");
    }

    public override object Clone()
    {
        return new Line(a, b);
    }
}

// Производный класс Kub: y = ax^2 + bx + c
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

    public override double Calculate(double x)
    {
        return a * x * x + b * x + c;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Куб: y = {a}x^2 + {b}x + {c}");
    }

    protected override int CompareToSameType(Function other)
    {
        if (other is Kub otherKub)
        {
            return a.CompareTo(otherKub.a); // Сортировка по коэффициенту a
        }
        throw new ArgumentException("Сравнение с функцией, не являющейся кубической, не поддерживается.");
    }

    public override object Clone()
    {
        return new Kub(a, b, c);
    }
}

// Производный класс Hyperbola: y = a/x
public class Hyperbola : Function
{
    public double a { get; set; }

    public Hyperbola(double a)
    {
        this.a = a;
    }

    public override double Calculate(double x)
    {
        if (x == 0)
        {
            throw new ArgumentException("Значение x не может быть равно нулю для гиперболы.");
        }
        return a / x;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Гипербола: y = {a}/x");
    }

    protected override int CompareToSameType(Function other)
    {
        if (other is Hyperbola otherHyperbola)
        {
            return a.CompareTo(otherHyperbola.a); // Сортировка по коэффициенту a
        }
        throw new ArgumentException("Сравнение с функцией, не являющейся гиперболой, не поддерживается.");
    }

    public override object Clone()
    {
        return new Hyperbola(a);
    }
}


class Figuri
{
    static void Main(string[] args)
    {
        // Создание списка функций
        List<Function> functions = new List<Function>
        {
            new Line(2, 3),
            new Kub(1, -4, 5),
            new Hyperbola(10),
            new Line(1, 0),
            new Kub(2, 2, 2)
        };

        // Сортировка списка функций по коэффициенту a
        functions.Sort();

        // Вывод информации о функциях в точке x
        double x = 2.0;
        foreach (var func in functions)
        {
            func.DisplayInfo();
            Console.WriteLine($"Значение в точке x = {x}: {func.Calculate(x)}");
            Console.WriteLine();
        }

        // Клонирование функции
        Function clonedFunction = (Function)functions[0].Clone();
        Console.WriteLine("Клонированная функция:");
        clonedFunction.DisplayInfo();
    }
}
