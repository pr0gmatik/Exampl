//for (int i = 2; i <= 100; i += 2) Console.WriteLine(i);
Console.WriteLine("Введите число : ");

int a = Convert.ToInt32(Console.ReadLine());

int i = 2;
while (i<a)
{
    Console.Write($"{i} ");
    i = i+2;
}
//else
//{
//Console.WriteLine();
//}