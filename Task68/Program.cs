System.Console.WriteLine("Enter m:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter n:");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Ackermann(m, n));
int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}