//Напишите программу, которая на вход принимает
//два числа и проверяет, является ли первое число
//квадратом второго
//считываем данные с консоли
string? inputNum1 = Console.ReadLine();

string? inputNum2 = Console.ReadLine();
//проверяем, чтобы данные не были пустыми
if(inputNum1!=null && inputNum2!=null)

{  
//парсим первое число//
    int number1 = int.Parse(inputNum1);
//парсим второе число//
    int number2 = int.Parse(inputNum2);

    if(number1==number2*number2)

    {
       Console.WriteLine("Первое число квадрат второго");
    }
    else
    {
       Console.WriteLine("Первое число не квадрат второго");
    }
}