Console.WriteLine("Input three-digit number:");
int num = Convert.ToInt32(Console.ReadLine());
int count;
count = num % 100 /10;
Console.WriteLine($"The second digit of {num} is {count}");