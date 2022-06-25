//задача. программа выводит трехзначное число и удаляет вторую цифру этого числа

int NewNumWithoutSecDigit()//void NewNumWithoutSecDigit()
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine("Your Current number is " + rand);
    int des = rand / 100;
    int ed = rand % 10;
    int NumWithoutSecDig = des * 10 + ed;
    Console.WriteLine("Your new number is " + NumWithoutSecDig);
    return NumWithoutSecDig;//-

}
 int res = NewNumWithoutSecDigit();//сохраняем  функцию в переменной res