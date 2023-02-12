/* Задача 66: Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int GetLeinght(string msg){
    int result = 0;
    while(true){
        Console.Write(msg);
        if(int.TryParse(Console.ReadLine(), out result)&& result>0) break;
        else Console.WriteLine("Введите коректное число!");
    }
    return result;
}
int SumFirstFinish(int first, int finish)
{
    int result = first;
    if (first == finish)
        return 0;
    else
    {
        first++;
        result = first + SumFirstFinish(first, finish);
        return result;
    }
}
void SumDig(int first, int finish)
{
    Console.Write(SumFirstFinish(first - 1, finish));
}

int numberStart = GetLeinght("Введите число с которого будет идти последовательность: ");
int numberFinish = GetLeinght("Введите до какого числа будет идти последовательность: ");
Console.WriteLine();
Console.Write($"Сумма натуральных чисел в промежутке от {numberStart} до {numberFinish} = ");
SumDig(numberStart,numberFinish);
