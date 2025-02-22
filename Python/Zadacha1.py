# Вводим размер списка
n = int(input("Введите размер списка: "))

# Проверяем, что n - натуральное число
if n <= 0:
    print("Размер списка должен быть натуральным числом.")
else:
    # Вводим элементы списка
    numbers = []
    for i in range(n):
        while True:
            num = int(input(f"Введите элемент {i + 1} (натуральное число): "))
            if num > 0:  # Проверяем, что число натуральное
                numbers.append(num)
                break
            else:
                print("Пожалуйста, введите натуральное число.")

    # Находим двузначные числа
    two_digit_numbers = [num for num in numbers if 10 <= num < 100]

    # Проверяем, есть ли двузначные числа
    if two_digit_numbers:
        # Вычисляем среднее арифметическое
        average = sum(two_digit_numbers) / len(two_digit_numbers)
        print(f"Среднее арифметическое двузначных чисел: {average}")
    else:
        print("В списке нет двузначных чисел.")
