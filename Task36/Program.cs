using static System.Console;

Write("Введите размер, минимальное и максимальное значения массива через запятую: ");
string [] parametres = ReadLine()!.Split(",", StringSplitOptions.RemoveEmptyEntries);

int [] array = getArray(int.Parse(parametres[0]), int.Parse(parametres[1]), int.Parse(parametres[2]));
printArray(array);
WriteLine($"Сумма чисел на нечетных позициях = {countArray(array)}");

int [] getArray(int sz, int minVl, int maxVl);
{
    Random rnd = new Random ();
    int [] arr = new int [sz];
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
    writeLine($"{arr[arr.Length-1]}]");
}

int countArray(int [] arr)
{
    sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2==1)
        {
            sum+=arr[i];
        }
    }
    return sum;
}