/* Задача 28: Напишите программу, которая принимает
 на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

bool IsNumberPOsitive(int number)
{
    return number > 0;
}

// cчитаем сумму чисел
int GetProductFromoneToNumber(int number)
{
    int product = 1;

    for(int i = 1; i <= number; i++)
       product  *= i;

    return product ;
}


Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if(IsNumberPOsitive(number))
{
    int product = GetProductFromoneToNumber(number);
    Console.WriteLine($"Сумма чисел от 1 до n: {product}");
}
else
{
    Console.WriteLine($"Некоретное число");
}


