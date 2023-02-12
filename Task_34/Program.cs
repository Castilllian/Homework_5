// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] BasArray = GetRandomArray(4,1,999);
Console.WriteLine(String.Join(" ", BasArray));

int[] GetRandomArray(int size, int minValue, int maxValue) // - создание рандомного массива
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int NewArray(int[] array) // - вычисление четных чисел массива
{
    int summ = 0;
    int size1 = array.Length;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]%2 == 0)
        {
            summ+=1;
        }
    }
    return summ;
   
}
Console.WriteLine($"Количество четных чисел массива = {NewArray(BasArray)}");
