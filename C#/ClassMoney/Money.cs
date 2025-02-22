using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMoney
{
    public class Money
    {
        // Закрытые атрибуты
        private int rubles;
        private int kopeks;

        private static int objectCount = 0;

        public int Rubles
        {
            get { return rubles; }
            set { rubles = value >= 0 ? value : throw new ArgumentException("Рубли не могут быть отрицательными."); }
        }

        public int Kopeks
        {
            get { return kopeks; }
            set
            {
                if (value >= 0)
                {
                    rubles += value / 100;
                    kopeks = value % 100;
                }
                else
                {
                    throw new ArgumentException("Копеек не может быть меньше 0.");
                }
            }
        }

        // Конструктор
        public Money(int rubles, int kopeks)
        {
            Rubles = rubles;
            Kopeks = kopeks;
            objectCount++;
        }

        // Пустой конструктор по умолчанию
        public Money() : this(0, 0) { }

        #region Metods
        // Получение общего количества копеек для удобства сравнения
        public int TotalKopeks()
        {
            return rubles * 100 + kopeks;
        }

        // Статический метод для добавления копеек к объекту Money
        public static Money AddKopeks(Money money, int additionalKopeks)
        {
            int totalKopeks = money.kopeks + additionalKopeks;
            int newRubles = money.rubles + totalKopeks / 100;
            int newKopeks = totalKopeks % 100;

            return new Money(newRubles, newKopeks);
        }

        // Статический метод для получения количества созданных объектов
        public static int GetObjectCount()
        {
            return objectCount;
        }

        // Метод для вывода информации об объекте
        public void PrintInfo()
        {
            Console.WriteLine($"Рубли: {rubles}, Копейки: {kopeks}\n");
        }

        // Метод для добавления копеек
        public void AddKopeks(int kopeksToAdd)
        {
            int totalKopeks = kopeks + kopeksToAdd;
            rubles += totalKopeks / 100;
            kopeks = totalKopeks % 100;

            Kopeks += kopeksToAdd;
        }
        #endregion Metods

        #region UnarnPeregruzka
        // Перегрузка унарного оператора ++ (добавление копейки)
        public static Money operator ++(Money money)
        {
            money.AddKopeks(1);
            return money;
        }

        // Перегрузка унарного оператора -- (вычитание копейки)
        public static Money operator --(Money money)
        {
            if (money.kopeks == 0)
            {
                if (money.rubles > 0)
                {
                    money.rubles--;
                    money.kopeks = 99;
                }
                else
                {
                    throw new InvalidOperationException("Невозможно вычесть копейку: баланс не может быть меньше 0.");
                }
            }
            else
            {
                money.kopeks--;
            }
            return money;
        }
        #endregion UnarnPeregruzka

        #region Privedenie
        // Приведение к int (количество рублей)
        public static explicit operator int(Money money)
        {
            return money.rubles;
        }

        // Приведение к double (доля копеек)
        public static implicit operator double(Money money)
        {
            return money.kopeks / 100.0;
        }
        #endregion Privedenie

        #region BinarnPeregruzka
        // Перегрузка бинарного оператора + (добавление копеек)
        public static Money operator +(Money money, int kopeks)
        {
            money.AddKopeks(kopeks);
            return money;
        }

        // Перегрузка бинарного оператора + (добавление копеек, правосторонний)
        public static Money operator +(int kopeks, Money money)
        {
            return money + kopeks;
        }

        // Перегрузка бинарного оператора - (вычитание копеек)
        public static Money operator -(Money money, int kopeks)
        {
            int totalKopeks = money.rubles * 100 + money.kopeks - kopeks;
            if (totalKopeks < 0)
            {
                throw new InvalidOperationException("Невозможно вычесть копейки: баланс не может быть меньше 0.");
            }
            money.rubles = totalKopeks / 100;
            money.kopeks = totalKopeks % 100;
            return money;
        }

        // Перегрузка бинарного оператора - (вычитание копеек, правосторонний)
        public static Money operator -(int kopeks, Money money)
        {
            return money - kopeks;
        }

        // Перегрузка оператора сравнения <
        public static bool operator <(Money m1, Money m2)
        {
            return m1.TotalKopeks() < m2.TotalKopeks();
        }

        // Перегрузка оператора сравнения >
        public static bool operator >(Money m1, Money m2)
        {
            return m1.TotalKopeks() > m2.TotalKopeks();
        }
        #endregion BinarnPeregruzka
    }
}
