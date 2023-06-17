Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("{0} → ", number);
for (int i = 2; i <= number; i += 2)
{
    Console.Write("{0} ", i);
}

Console.WriteLine(" ");