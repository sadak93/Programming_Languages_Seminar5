// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
// равна 29, сумма отрицательных равна -20.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

void FindSums(int[] array)
{
    int sumP=0;
    int sumN=0;
    foreach (var item in array)
        if (item>0)
            sumP+=item;
        else    
            sumN+=item;
    System.Console.WriteLine($"Сумма отрицательных элементов массива равна {sumN}");
    System.Console.WriteLine($"Сумма положительных элементов массива равна {sumP}");
}

int[] FindSums2(int[] array)
{
    int sumP = 0;
    int sumN = 0;
    foreach (var item in array)
        if (item > 0)
            sumP += item;
        else
            sumN += item;
    int[] result = { sumN, sumP };// int[] result = {1,2,3,4,5,6};
    return result;
}

Console.Clear();
System.Console.WriteLine("Введите размерность массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
FindSums(array);
PrintArray(FindSums2(array));

