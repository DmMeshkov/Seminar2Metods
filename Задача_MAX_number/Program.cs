//Программа генерирует случайное число из отрезка от 10 до 99 и показывает наибольшую цифру сгенерированного числа.

void ShowBiggerDigit()
{
    int rand = new Random().Next(10, 100);//100 не учитывается. будет 99
    Console.WriteLine("Our current number is " + rand);
    int dec = rand / 10;
    int ed = rand % 10;
    int max;
    if (dec > ed) max = dec;
    else max = ed;
    Console.WriteLine("Bigger digit is " + max);

}

ShowBiggerDigit();
