Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}

if (num3 > max)
{
    max = num3;
}

Console.WriteLine("{0}, {1}, {2} -> max = {3}", num1, num2, num3, max);

/*
Данный код сначала принимает пользовательский ввод трех чисел, затем сравнивает их и находит максимальное из них. Начальным максимальным значением устанавливается первое число.

Затем каждое последующее число сравнивается с текущим максимальным значением, и если это число больше - оно становится новым максимальным значением. 

В конце выводится сообщение в формате "{0}, {1}, {2} → max = {3}", где {0}, {1}, {2} - это введенные пользователем числа, а {3} - их максимальное значение.
*/