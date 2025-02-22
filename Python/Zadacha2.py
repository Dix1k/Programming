import random

# Генерируем список из 10 случайных вещественных чисел
numbers = [random.uniform(0, 100) for _ in range(10)]
print("Сгенерированный список:", numbers)

# Ищем наибольший элемент с нечётным индексом
max_odd_index_value = None

for i in range(1, len(numbers), 2):  # Начинаем с 1 и идем с шагом 2
    if max_odd_index_value is None or numbers[i] > max_odd_index_value:
        max_odd_index_value = numbers[i]

# Выводим результат
if max_odd_index_value is not None:
    print("Наибольший элемент с нечётным индексом:", max_odd_index_value)
else:
    print("Нет элементов с нечётными индексами.")