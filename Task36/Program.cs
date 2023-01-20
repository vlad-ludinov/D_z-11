using static System.Console;

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