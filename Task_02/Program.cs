Console.WriteLine("Please, input the first integer number!");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, input the second integer number!");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 == n2) {
    Console.WriteLine("You inputed the equal numbers!");
} else if (n1 > n2) {
    Console.WriteLine($"The first number {n1} more then the second number {n2} !");
} else {
    Console.WriteLine($"The first number {n1} less then the second number {n2} !");
}
