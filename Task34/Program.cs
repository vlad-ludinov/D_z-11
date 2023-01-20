using static System.Console;

Write("Введите размер массива:");
int size = int.Parse(ReadLine()!);

int[] getArray(int [] sz)
{
    Random rnd = new Random();
    int [] arr = new int [sz];
    for (int i = 0; i < size; i++)
    {
        sz[i] = rnd.Next(100,1000);
    }
}
