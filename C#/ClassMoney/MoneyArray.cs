using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMoney
{
    public class MoneyArray
    {
        private Money[] arr;
        private int size;

        #region Constructors
        // Конструктор без параметров
        public MoneyArray()
        {
            size = 5;
            arr = new Money[size];
        }

        // Конструктор с параметрами, заполняющий массив случайными значениями
        public MoneyArray(int size)
        {
            this.size = size;
            arr = new Money[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = new Money(rand.Next(0, 1000), rand.Next(0, 100));
            }
        }

        // Конструктор с параметрами, позволяющий заполнить массив с клавиатуры
        public MoneyArray(int size, bool fillFromUser)
        {
            this.size = size;
            arr = new Money[size];
            if (fillFromUser)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"Введите рубли для элемента {i + 1}: ");
                    int rubles = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Введите копейки для элемента {i + 1}: ");
                    int kopeks = int.Parse(Console.ReadLine());
                    arr[i] = new Money(rubles, kopeks);
                }
            }
        }
        #endregion Constructors

        // Индексатор для доступа к элементам массива
        public Money this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        #region Metods
        // Метод для просмотра элементов массива
        public void PrintArray()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Элемент {i + 1}:");
                arr[i].PrintInfo();
            }
        }

        // Метод для поиска минимального значения в массиве
        public Money FindMinimum()
        {
            if (size == 0) throw new InvalidOperationException("Массив пуст.");
            Money min = arr[0];
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        #endregion Metods
    }

}
