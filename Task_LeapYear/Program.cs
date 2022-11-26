int numberYear = new Random().Next(1900, 2100);
if ((numberYear - 1896) % 4 == 0) Console.WriteLine("This year {0} is leap! ", numberYear);
else Console.WriteLine("This year {0} is NOT leap! ", numberYear);