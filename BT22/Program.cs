static bool DayTang(int[] arr)
{
    for(int i=1; i<arr.Length;i++)
    {
        if (arr[i] < arr[i-1])
        {
            return false;
        }
    }
    return true;
}
static int DayConMax(int[] arr)
{
    int startIndex = 0;
    int maxLength = 1;
    int i = 1;
    for(i;i<arr.Length;i++)
    {
        if (arr[i] < arr[i - 1])
        {
            break;
        }
    }
}
int[] arr1 = { 1, 3,10, 7, 9};
if (DayTang(arr1))
{
    Console.WriteLine("Day tang");
}
else
{
    Console.WriteLine("Khong la day tang");
}
Array.Sort(arr1); 
Console.WriteLine(string.Join(" ", arr1));