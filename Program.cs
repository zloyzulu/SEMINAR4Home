 //Программа принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

 /*
Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = 1;
int Vira(int num1, int num2)
{
  for(int i = 1; i <= num2; i++)
  {
    result = result * num1;
  }
    
    return result;
}
    
int positiv = Vira(num1, num2);
Console.WriteLine($"{num1} ^ {num2} = "  + positiv);

*/


//Программа принимает на вход число 
//и выдаёт сумму цифр в числе.

/*
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int s = 0;

while (a > 0)
{
s = s + a % 10;
a = a /10 ;
}
Console.WriteLine("Сумма цифр в числе = " + s);

 */           
 


//Программа задаёт массив из произвольных элементов 
//и выводит их на экран.
  
  /*
  //Параметр метода Main представляет собой массив строк,
  // представляющий аргументы командной строки.

 class Programm
{
  static void Main(string[] args)
  {
Console.Write("Введите количество элементов массива:" );
int elements = Convert.ToInt32(Console.ReadLine());
int [] myArray = new int[elements];
  for (int i = 0; i < myArray.Length;i++)
  {
Console.Write("Введите элемент массива:");
myArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("[");
for (int i = 0;i < myArray.Length;i++)
{
Console.Write(myArray[i]);
}
Console.Write("]");
  }
}
*/
  

