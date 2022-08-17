Console.Clear();
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count =1;
while (count <= N)
{
    Console.WriteLine(Math.Pow((count),3));
    count++;
}
