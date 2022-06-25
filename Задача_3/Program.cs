//программа принимает 2 числа и выводит являетсяли второе число кратным первому. Если второе число не кратно первому, выводится остаток от деления.





int CheckNumbers(int n1, int n2)

{
    if (n2 % n1 == 0)
    {
        Console.WriteLine($"Второе число {n2} кратно первому {n1}");
        return 0;
    }
    else
    {
        int remainder = n2 % n1;
        Console.WriteLine($"Второе число {n2} не кратно первому {n1}. Остаток {remainder}");
        return remainder;
    }

}
Console.WriteLine("Input two numbers");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int res = CheckNumbers(n1, n2);

