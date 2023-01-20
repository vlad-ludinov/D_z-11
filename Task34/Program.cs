using static System.Console;

Write("Введите размер массива:");
int size = int.Parse(ReadLine()!);

int [] array = getArray(size);
printArray(array);
WriteLine($"Четных чисел в массиве: {countArray(array)}");

int[] getArray(int  sz)
{
    Random rnd = new Random();
    int [] arr = new int [sz];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100,1000);
    }
    return arr;
}

int countArray (int [] arr)
{
    int count = 0;
    foreach (var a in arr)
    {
        if (a%2 == 0)
        {
            count+=1;
        } 
    }
    return count;
}

void printArray(int [] arr)
{
    Write("Массив: [");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Write($"{arr[i]}, ");
    }
    WriteLine($"{arr[arr.Length]}]");
}