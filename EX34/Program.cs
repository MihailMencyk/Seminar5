// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        System.Console.Write($"{array[i]} ");
    }
System.Console.WriteLine();
}

int[] array = new int [5];
PrintArray (array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0) count = count + 1;
}
System.Console.WriteLine($"Количество четных чисел: {count}");