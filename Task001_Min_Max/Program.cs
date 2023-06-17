Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max, min;

if (num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num2;
    min = num1;
}

Console.WriteLine("max = {0}", max);
Console.WriteLine("min = {0}", min);

/*
Данный код вначале принимает пользовательский ввод двух чисел и затем сравнивает их. Если первое число больше, чем второе, то значение первого числа присваивается переменной `max`, а значение второго числа - переменной `min`. В противном случае значения присваиваются  наоборот.

Далее происходит вывод значения `max` в формате "max = {0}", где {0} - это значение переменной `max`, и значения `min` в формате "min = {0}", где {0} - это значение переменной `min`.
*/