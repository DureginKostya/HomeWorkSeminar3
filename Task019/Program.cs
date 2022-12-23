/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.*/
Console.Clear();
int GetUserValue(string Message)
{
    Console.Write(Message);
    int Result = int.Parse(Console.ReadLine()!);    
    return Result;
}
string CheckingNumber(int UserNumber)
{
    string Answer = "Число меньше 11 не может быть палиндромом";
    if (UserNumber > 10)
    {
        int CountTen = GetCountTen(UserNumber);
        Answer = DeterminationNumberPalindrome(UserNumber, CountTen);
    }    
    return Answer;
}
int GetCountTen(int Number)
{
    int Count = 0;
    while (Number > 0)
    {
        Number = Number / 10;
        Count++;
    }  
    return Count;
}
string DeterminationNumberPalindrome(int NumberPalindrome, int Order)
{    
    string Decision = $"Число {NumberPalindrome} является палиндромом";            
    int Count = Order / 2;
    int Index = 0;
    int Degree = Order - 1;
    int ProcessedNumber = NumberPalindrome;
    while (Index < Count)
    {
        int DigitFirst = ProcessedNumber / ((int)Math.Pow(10, Degree));
        int DigitLast = ProcessedNumber % 10;
        if (DigitFirst != DigitLast)
        {
            Decision = $"Число {NumberPalindrome} не является палиндромом";
            break;
        }
        ProcessedNumber = ProcessedNumber % ((int)Math.Pow(10, Degree));
        ProcessedNumber = ProcessedNumber / 10;
        Degree = Degree - 2;
        Index++;        
    }    
    return Decision;
}
int EnterNumber = GetUserValue("Введите число: ");
string Palindrome = CheckingNumber(EnterNumber);
Console.WriteLine(Palindrome);