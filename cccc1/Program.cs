

using System.Net.NetworkInformation;

static bool DoiXung(int n)
{
    int n0 = n;
    int n1 = 0;
    while (n > 0)
    {
        int a = n % 10;
        n1 = n1*10 + a;
        n = n / 10;
    }
    return n1 == n0;
}
static bool NguyenTo(int n)
{
    for(int i=2;i<n;i++)
    {
        if(n%i == 0)
        {
            return false;
        }
    }
    return true;
}
static bool HoanHao(int n)
{
    int n0 = n;
    int n1 = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            n1 = n1 + i;
        }
    }
    return n1 == n0;
}
Console.WriteLine("Nhap vao so nguyen duong N: ");
if (int.TryParse(Console.ReadLine(), out int N))
{
    if (DoiXung(N))
    {
         Console.WriteLine($"{N} la so doi xung");
    }
    else
    {
         Console.WriteLine($"{N} khong doi xung");
    }
    if(NguyenTo(N))
    {
        Console.WriteLine($"{N} nguyen to");
    }
    else
    {
        Console.WriteLine($"{N} khong nguyen to");
    }
    if (HoanHao(N))
    {
        Console.WriteLine($"{N} hoan hao");
    }
    else
    {
        Console.WriteLine($"{N} khong hoan hao");
    }
}
