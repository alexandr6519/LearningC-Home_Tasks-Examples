Console.WriteLine("Please, input the integer number!");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"The list of simple numbers between 2 and {0} is: ", n);

for (int i = 2; i <= n; i++)
{
    bool isSimple = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isSimple = false;
            break;
        }
    }
    if (isSimple) Console.Write(i + " ");
}