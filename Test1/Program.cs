Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
 Console.WriteLine("Большее число = " + num1);
}
else if (num1 < num2)
{
 Console.WriteLine("Большее число = " + num2);
}
else if (num1 == num2)
{
 Console.WriteLine("Числа равны");
}
else
{
 Console.WriteLine("Неверный ввод");
}
