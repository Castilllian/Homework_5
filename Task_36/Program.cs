// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] BasArray = GetRandomArray(5,1,10);
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
int FollowArray(int[] array) // - поиск суммы на нечетных позициях
{
    int i = 0;
    int summ = 0;
    int size1 = array.Length;
    for(i=1; i<size1;i+=2)
    {
       summ += array[i];
    }
    return summ;
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {FollowArray(BasArray)}");