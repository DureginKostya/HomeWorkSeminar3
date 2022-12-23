/*Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.*/
Console.Clear();
int GetUserValue(string Message)
{
    Console.Write(Message);
    int Value = int.Parse(Console.ReadLine()!);
    return Value;
}
void TableValue(int UserNumber)
{
    if (UserNumber > 1)
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Числа от 1 до {UserNumber} || Числа в кубе ");
        Console.WriteLine("---------------------------------");
        for (int i = 1; i <= UserNumber; i++)
        {
            int Number = (int)Math.Pow(i, 3);
            Console.WriteLine($"        {i}       ||       {Number} ");
            Console.WriteLine("---------------------------------");
        }
    }
    else
    {
        Console.WriteLine("Введено недопустимое число, N должно быть больше единицы");
    }
}

int Number = GetUserValue("Введите число: ");
TableValue(Number);