// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

int number = 100000;
int tempNumber = number;
int listNumber = 0;

if (number > 0 && number < 100000)
{
    while (tempNumber > 0)
    {
        tempNumber /= 10;
        listNumber++;
    }
    // Console.WriteLine(listNumber);

    int[] arr = new int[listNumber];
    tempNumber = number;

    for (int i = listNumber - 1; i >= 0; i--)
    {
        arr[i] = tempNumber % 10;
        tempNumber /= 10;
    }

    Console.Write($"Массив цифр числа {number} => ");
    foreach(int e in arr)
    {
        Console.Write($"{e} ");
    }
}

else
{
    Console.Write($"Число {number} не входит в заданный диапозон");
}