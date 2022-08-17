Console.Clear();
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
if (number.Length ==5)
{
  if (number[0]==number[4] && number[1]==number[3])
  {
  Console.WriteLine("Вы ввели палиндром");
  }
  else
  {
  Console.WriteLine("Число не является палиндромом");   
  }
}
else
{
  Console.WriteLine("Вы ввели не пятизначное число");   
}