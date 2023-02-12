/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */


int GetLeinght(string msg){
    int result = 0;
    while(true){
        Console.Write(msg);
        if(int.TryParse(Console.ReadLine(), out result)&& result>0) break;
        else Console.WriteLine("Введите коректное число!");
    }
    return result;
}
int Akkerman(int first, int second)
{
    if (first == 0)
    {
        return second + 1;
    }
    else if (second == 0 && first > 0)
    {
        return Akkerman(first - 1, 1);
    }
    else
    {
        return (Akkerman(first - 1, Akkerman(first, second - 1)));
    }
}

void AkkermanPrint(int first, int second)
{
    Console.Write(Akkerman(first, second)); 
}

int first = GetLeinght("Введите первое число : ");
int second = GetLeinght("Введите второе число : ");
Console.Write($"Даны два числа {first} и {second}. Их число Аккермана = ");
AkkermanPrint(first,second);