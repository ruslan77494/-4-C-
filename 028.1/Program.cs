/* Задача 28: Напишите программу, которая принимает
 на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/


Console.WriteLine(" Пожалуйста  введите число");

int num = int.Parse(Console.ReadLine());
int result = GetProdOfNum(num);
Console.WriteLine($"Произведение чисел от 1 до N  ->  (  {result}  )");

int GetProdOfNum(int num)
{
    int product = 1;

    for(int i = 1; i <= num; i++)
       product  *= i;

    return product ;
}





