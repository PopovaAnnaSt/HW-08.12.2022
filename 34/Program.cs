// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
int[] array = GetArray(15, 100, 999);
Console.WriteLine(String.Join(" ", array));

Console.WriteLine($"Количество чётных чисел = {CountEvenNumbers(array)}");

int CountEvenNumbers(int[] array) // Счётчик чётных чисел
{
    int count = 0;
    foreach (var item in array)
    {
        if ((item % 2) == 0) count++;
    }
    return count;
}

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); 
    }                                                      
    return res;
}