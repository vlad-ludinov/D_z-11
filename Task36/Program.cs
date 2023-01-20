using static System.Console;

Write("Введите размер, минимальное и максимальное значения массива через запятую: ");
string [] parametres = ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);

int [] array = getArray(int.Parse(parametres[0]), int.Parse(parametres[1]), int.Parse(parametres[2]));
printArray(array);
WriteLine($"Сумма чисел на нечетных позициях = {countArray(array)}");

int [] getArray(int sz, int minVl, int maxVl)
{
    int [] arr = new int [sz];
    Random rnd = new Random();
    for (int i = 0; i < sz; i++)
    {
        arr[i] = rnd.Next(minVl, maxVl);
    }
    return arr;
}

void printArray(int [] arr)
{
    Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Write($"{arr[i]}, ");
    }
    WriteLine($"{arr[arr.Length-1]}]");
}

int countArray(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2==1)
        {
            sum+=arr[i];
        }
    }
    return sum;
}