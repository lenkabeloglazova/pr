
//  Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  N = 5. -> "5, 4, 3, 2, 1"
//  N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

 Console.WriteLine("Введите натуральное число больше 1:");
int.Parse(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
void NumberCounter (int)
{


    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number  == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}

NumberCounter(number);
