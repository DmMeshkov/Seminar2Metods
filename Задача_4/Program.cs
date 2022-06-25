/*int Check(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine("Число делится");
        return 1;
    }
    else Console.WriteLine("Число не делится");
    return 0;
}

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int check = Check(number);
Console.WriteLine(check);*/

bool Check(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
        return true;
    else
        return false;
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
bool res = Check(number);
Console.WriteLine(res);