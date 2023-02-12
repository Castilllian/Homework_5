// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2]-> 0

// [10, 11, 12, 13, 14]-> 5

int[] GetRandomArray(int size, int minValue, int maxValue) // - создание рандомного массива
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int FindElement(int [] array)
{
    int i=0;
    foreach(int n in array)
    {
        if(n >= 10 && n <=99 )
        {
            i++;
        }
    }
    return i;
}


// int PromtInt(string messege) // - метод ввода данных
// {
//     Console.Write(messege);
//     int input = int.Parse(Console.ReadLine());
//     return input;
// }

string PrintArray(int[] array) // - метод выстраивания значений в массив
{
    string writeArray = String.Join(" ,", array);
    return writeArray;
}

Console.Clear(); 
int [] arr = GetRandomArray(123,0,1001);
Console.WriteLine(PrintArray(arr));
Console.WriteLine($"Количество чисел в массиве, которые находятся в диапазоне от 10 до 99 = {FindElement(arr)}");
