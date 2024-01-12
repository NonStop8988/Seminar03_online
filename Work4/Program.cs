// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. Младший разряд числа должен располагаться на 0-м индексе массива, старший – на 2-м индексе массива.
int naturalNumber = 456;
// int digit = 1;

int[] arrDigit = new int[3];
arrDigit[0] = naturalNumber % 10;
arrDigit[1] = naturalNumber % 100 / 10;
arrDigit[2] = naturalNumber /100;
Console.Write($"{arrDigit[0]} {arrDigit[1]} {arrDigit[2]}");







// // Определяем разрядность заданного числа
// while (naturalNumber / digit > 10)
// {
//     digit *= 10;
// }
// // Console.Write(digit);

// // Создаем новый массив, состоящий из цифр заданного числа
// int[] arrDigit = new int [3];
// Console.Write($"{arrDigit.Length} ;");

// // for (int i = 0; i < arrDigit.Length; i++)
// // {
// //     arrDigit[i] = naturalNumber / digit;
// //     Console.Write($"{arrDigit[i]} ");
// //     naturalNumber %= digit;
// //     digit /= 10;
// // }


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите трёхзначное число: ");
//         int number = int.Parse(Console.ReadLine());

//         if (number < 100 || number > 999)
//         {
//             Console.WriteLine("Введенное число не является трёхзначным.");
//             return;
//         }

//         int[] digits = GetDigitsArray(number);

//         Console.WriteLine("Массив цифр числа:");

//         for (int i = 0; i < digits.Length; i++)
//         {
//             Console.WriteLine($"digits[{i}] = {digits[i]}");
//         }
//     }

//     static int[] GetDigitsArray(int num)
//     {
//         int[] digits = new int[3];

//         digits[0] = num % 10;         // единицы
//         digits[1] = (num / 10) % 10;  // десятки
//         digits[2] = num / 100;        // сотни

//         return digits;
//     }
// }
