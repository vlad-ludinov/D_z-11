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