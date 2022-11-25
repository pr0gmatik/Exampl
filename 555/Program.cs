 Console.WriteLine("Введите число:  ");
 int n = Convert.ToInt32(Console.ReadLine());
 int num = -n;
 while (num <= n)
 {
     Console.Write($"{num} ");
     num++;
 }
 string user = Console.ReadLine();