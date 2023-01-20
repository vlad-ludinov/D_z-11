using static System.Console;

Write("Введите размер, минимальное и максимальное значение массива через запятую: ");
string [] parametres = ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

double [] array = getArray(int.Parse(parametres[0]), Convert.ToDouble(parametres[1]), Convert.ToDouble(parametres[2]));
printArray(array);
Value V = countArray(array);
WriteLine(V.min);
WriteLine(V.max);
WriteLine($"Разница между максимальным и минимальными числами: {V.max-V.min}");

double [] getArray(int sz, double minVl, double maxVl)
{
    double delta = maxVl - minVl;
    Random rnd = new Random();
    double [] arr = new double [sz];
    for (int i = 0; i < sz; i++)
    {
        arr[i] = ((rnd.NextDouble())+(minVl/delta))*delta;
    }
    return arr;
}

void printArray(double [] arr)
{
    Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Write($"{arr[i]}; ");
    }
    WriteLine($"{arr[arr.Length-1]}]");
}

Value countArray(double [] arr)
{
    Value Vl = new Value();
    Vl.min = arr[0];
    foreach (var a in arr)
    {
        if (a<Vl.min)
        {
            Vl.min = a;
        }
    }
    Vl.max = arr[0];
    foreach (var a in arr)
    {
        if (a>Vl.max)
        {
            Vl.max = a;
        }
    }
    return Vl;
}

struct Value
{
    public double min;

    public double max;
}