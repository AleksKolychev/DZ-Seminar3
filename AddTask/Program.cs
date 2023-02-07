Console.Clear();

Console.WriteLine("Введите количество кустов");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество ягод на кустах");
int[] array = new int[n];

for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());

int maxSum = 0;
for (int i = 1; i < array.Length - 1; i++)
{
    int sum = array[i - 1] + array[i] + array[i + 1];
    if (sum > maxSum)
        maxSum = sum;
}
if (array[0] + array[1] + array[array.Length - 1] > maxSum)
    maxSum = array[0] + array[1] + array[array.Length - 1];
 
if (array[array.Length - 1] + array[array.Length - 2] + array[0] > maxSum)
    maxSum = array[array.Length - 1] + array[array.Length - 2] + array[0];
 
Console.WriteLine($"Максимальное количество ягод: {maxSum}");