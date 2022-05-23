/*Задача 26: Напишите программу, которая принимает
 на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/


string GetNumber ()
{
    return Console.ReadLine();
}

int CountNum(string str)
{
    return str.Length;
}

Console.WriteLine("Пожалуйста введите число:  ");
int countNum = CountNum(GetNumber());
Console.WriteLine(countNum);

