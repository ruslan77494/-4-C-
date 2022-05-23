/* Задача 24: Напишите программу, которая принимает
 на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
// Проверяет что число положительное
bool IsNumberPOsitive(int number)
{
    return number > 0;
}

// cчитаем сумму чисел
int GetSummFromoneToNumber(int number)
{
    int summ = 0;

    for(int i = 1; i <= number; i++)
        summ += i;

    return summ;
}


Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if(IsNumberPOsitive(number))
{
    int summ = GetSummFromoneToNumber(number);
    Console.WriteLine($"Сумма чисел от 1 до n: {summ}");
}
else
{
    Console.WriteLine($"Некоретное число");
}

