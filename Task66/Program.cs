int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumBetweenNAndM(n, m));
int SumBetweenNAndM(int n, int m)
{
    if (n >= m) return n;
    else
    {
        return n + SumBetweenNAndM(n + 1, m);
    }
}
