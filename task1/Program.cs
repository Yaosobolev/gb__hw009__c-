/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
int GetLeinght(string msg){
    int result = 0;
    while(true){
        Console.Write(msg);
        if(int.TryParse(Console.ReadLine(), out result)&& result>0) break;
        else Console.WriteLine("Введите коректное число!");
    }
    return result;
}
void GetRecursion(int n,int i){
    if(i<=n){
        Console.Write($"{n} ");
        n--;
        GetRecursion(n,i);
    }
    
}
int number = GetLeinght("Введите с какого числа будет идти последовательность: ");
int i = 1;
GetRecursion(number,i);