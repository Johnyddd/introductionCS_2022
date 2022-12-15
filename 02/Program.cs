// С клавиатуры вводятся два вещественных числа. Проверить является ли одно из них квадратом другого.

/*
//полное условие
if ()
{
//true
}
else
{
    //false
}
//не полное условие
if ()
{
    //true
}
*/

System.Console.WriteLine("введите число a:");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("введите число b:");
double b=Convert.ToDouble(Console.ReadLine());

if (a*a==b)
{ 
System.Console.WriteLine($"{b} является квадратом {a}");
}
if (b*b==a)
{
System.Console.WriteLine($"{a} является квадратом {b}");
}