using System;
using System.Collections;
using System.Linq;

public class MyNewCollection : Hashtable
{
    public string CollectionName { get; set; }
    public event CollectionHandler CollectionCountChanged;
    public event CollectionHandler CollectionReferenceChanged;

    public MyNewCollection(string name)
    {
        CollectionName = name;
    }

    public bool Remove(object key)
    {
        if (this.ContainsKey(key))
        {
            object removedItem = this[key];
            base.Remove(key);

            // Вызов события и вывод сообщения
            CollectionCountChanged?.Invoke(this, new CollectionHandlerEventArgs(
                CollectionName, "Удален элемент", removedItem));
            Console.WriteLine($"Коллекция: {CollectionName}, Тип изменения: Удален элемент, Данные: {removedItem}");

            return true;
        }
        return false;
    }

    public new object this[object key]
    {
        get => base[key];
        set
        {
            base[key] = value;

            // Вызов события и вывод сообщения
            CollectionReferenceChanged?.Invoke(this, new CollectionHandlerEventArgs(
                CollectionName, "Изменен элемент", value));
            Console.WriteLine($"Коллекция: {CollectionName}, Тип изменения: Изменен элемент, Данные: {value}");
        }
    }

    public void AddDefaults()
    {
        Add("Default1", "Value1");
        Add("Default2", "Value2");

        // Вызов события и вывод сообщения
        CollectionCountChanged?.Invoke(this, new CollectionHandlerEventArgs(
            CollectionName, "Добавлены элементы по умолчанию", null));
        Console.WriteLine($"Коллекция: {CollectionName}, Тип изменения: Добавлены элементы по умолчанию");
    }

    public void Add(object key, object value)
    {
        base.Add(key, value);

        // Вызов события и вывод сообщения
        CollectionCountChanged?.Invoke(this, new CollectionHandlerEventArgs(
            CollectionName, "Добавлен элемент", value));
        Console.WriteLine($"Коллекция: {CollectionName}, Тип изменения: Добавлен элемент, Данные: {value}");
    }

    public void Remove(int index)
    {
        var key = this.Keys.Cast<object>().ElementAt(index);
        var value = this[key];
        base.Remove(key);

        // Вызов события и вывод сообщения
        CollectionCountChanged?.Invoke(this, new CollectionHandlerEventArgs(
            CollectionName, "Удален элемент", value));
        Console.WriteLine($"Коллекция: {CollectionName}, Тип изменения: Удален элемент, Данные: {value}");
    }
}
