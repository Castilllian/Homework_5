
// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] GetRandomArray(int size, int minValue, int maxValue) // - создание рандомного массива
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int Differ(int [] array)
{
    int minN = array[0];
    int maxN = array[0];
    foreach(int n in array)
    {
        if(n<minN)
        {
            minN=n;
        }
        if(n>maxN)
        {
            maxN=n;
        }
    }
    int difference = maxN-minN;
    return difference;
}

int PromtInt(string messege) // - метод ввода данных
{
    Console.Write(messege);
    int input = int.Parse(Console.ReadLine());
    return input;
}

string PrintArray(int[] array) // - метод выстраивания значений в массив
{
    string writeArray = String.Join(" ,", array);
    return writeArray;
}

Console.Clear(); 
int arrSize = PromtInt("Введите число массива: ");
int arrMin = PromtInt("Введите минимальное число массива: ");
int arrMах = PromtInt("Введите максимальное число массива: ");
int [] arr = GetRandomArray(arrSize, arrMin, arrMах);
Console.WriteLine(PrintArray(arr));
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {Differ(arr)}");