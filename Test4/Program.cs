Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = 1;
while (result < num)
{
 Console.WriteLine(result + 1);
 result += 2;
}