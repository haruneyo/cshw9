int n = Convert.ToInt32(Console.ReadLine());
NumsFromNToOne(n);
void NumsFromNToOne(int num)
{
    if (num == 1) System.Console.WriteLine(num);
    else
    {
        System.Console.WriteLine(num);
        NumsFromNToOne(num - 1);
    }
}