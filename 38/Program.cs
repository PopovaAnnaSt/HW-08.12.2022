// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76

Console.Clear();
Double[] array = GetArray(8, 2, 6);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементами = {DiffMaxMinElements(array)}");

Double DiffMaxMinElements(Double[] array)
{
    Double max = array[0], min = array[0]; 
    //double max = min = array[0];
    foreach (var item in array)
    {
        if (item > max) max = item;
        if (item < min) min = item;
    }
    return (max - min);
}

Double[] GetArray(int size, Double minValue, Double maxValue) 
{
    Double[] res = new Double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * 4.0 + 2.0;
    }
    return res;
}