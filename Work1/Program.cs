int[] array = { 1, 2, 3, 4, 5 };
int target = 5;

bool flag = false; // флаг опущен (не посещался, нет такого элемента в массиве)

foreach (int elem in array)
{
    if (elem == target)
    {
        // Console.WriteLine(elem);
        flag = true;
    }
}

if (flag == true)
{
    Console.WriteLine($"Присутствует");
}
else
{
    Console.WriteLine($"Не присутствует");
}