//Напишите программу, которая принимает на вход три 
//числа и выдаёт максимальное из этих чисел.

//считываем данные с консоли
string? imputNum1 = Console.ReadLine();
string? imputNum2 = Console.ReadLine();
string? imputNum3 = Console.ReadLine();
//проверяем, чтобы данные не были пустыми
if (imputNum1 != null && imputNum2 != null && imputNum3!= null)
{
    //Парсим введенное число
    int number1 = int.Parse(imputNum1);
    int number2 = int.Parse(imputNum2);
    int number3 = int.Parse(imputNum3);
//Задаем условие
    if (number1 > number2 && number1 > number3)
    {
        ////выводим данные в консоль
        Console.WriteLine(number1);
    }
    //Продолжение цикла
    else if (number2 > number1 && number2 > number3)
    {
        Console.WriteLine(number2);
    }
    else if (number3 > number1 && number3 > number2)
    {
        //выводим данные в консоль
        Console.WriteLine(number3);
    }
}







