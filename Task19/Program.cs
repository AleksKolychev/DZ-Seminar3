Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (((n - n % 10000) / 10000 == n % 10) && (((n - n % 1000) /1000) % 10 == (n % 100 - n % 10) / 10))
Console.WriteLine("yes");
else 
Console.WriteLine("no");