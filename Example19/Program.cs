// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно 
// палиндромом.
    // 14212 -> нет
    // 12821 -> да
    // 23432 -> да

System.Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberLen = (int)Math.Log10(number);
int first = numberLen;
int last = 1;
int firstDigit = (int)(number / Math.Pow(10, numberLen));
int lastDigit = (number / last) % 10;

if (numberLen == 4)
{
    for (int i = 1; i <= ((numberLen + 1) / 2); i++)
    {
        if (firstDigit == lastDigit)
        {
            first = first - 1;
            last = last * 10;
            firstDigit = (int)(number / Math.Pow(10, first) % 10);
            lastDigit = (number / last) % 10;
        }
    }
    if (firstDigit == lastDigit)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Значение неверно! Введите пятизначное число!");
}