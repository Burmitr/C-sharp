int[] arr = { 1, 2, 3, 4, 5 };
int i = 0;
string test;
Console.WriteLine(arr.Length);
Console.WriteLine(i);
while (i < arr.Length) ;
{
    arr[i] *= i * 2;
    Console.Write(arr[i]);
    i++;
}
