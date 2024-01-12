// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.
int[] array = { 2, 3, 1, 7, 5, 6, 3 };
int averegeIndex = array.Length / 2;
int lastIndex = array.Length - 1;
int[] product = new int[averegeIndex];
// Console.Write(lastIndex);

// Произведение пар чисел
for (int i = 0; i < averegeIndex; i++)
{
    product[i] = array[i] * array[lastIndex];
    Console.Write(product[i]+" ");
    lastIndex -= 1;
}

// Проверка наличия в массиве элемента без пары
if (array.Length % 2 != 0)
{
    Console.WriteLine($"(элемент {array[averegeIndex]} не имеет пары)");
}