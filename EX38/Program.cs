// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива. [3 7 22 2 78] -> 76
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
int min = array[0];
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (min>array[i]) min = array[i];
}
for (int i = 1; i < array.Length; i++)
{
    if (max<array[i]) max = array[i];
}
System.Console.WriteLine($"максимальное: {max}, минимальное: {min}, Разница чисел: {max-min}");