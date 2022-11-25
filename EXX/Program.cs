Console.Write ("Введите число:  ");

//int n = int.Parse(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
Console.WriteLine(k < 0 ? "Нет" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());

//Console.ReadLine();