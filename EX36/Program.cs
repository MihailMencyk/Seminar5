// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 100);
        System.Console.Write($"{array[i]} ");
    }
System.Console.WriteLine();
}

int[] array = new int [4];
PrintArray (array);
int Sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i%2 != 0) Sum = Sum + array[i];
}
System.Console.WriteLine($"Сумма элементов с нечетным индексом: {Sum}");
