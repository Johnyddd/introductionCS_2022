//1. с клавиатуры вводится целое число. Вывести квадрат числа
int a;
a=10;
System.Console.Write("введите число:");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a*a;
System.Console.WriteLine(Convert.ToString(a)+"^2="+b.ToString());
System.Console.WriteLine($"{a}^2={b}");