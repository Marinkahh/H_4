// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите степень его числа: ");
int degree = int.Parse(Console.ReadLine());

Console.WriteLine(DegreeNums(num, degree));

int DegreeNums(int x, int y)
{
    int z=x;
  for( int i= 1; i<y; i++)
  {
    z=z*x;
  }
  return z;
}