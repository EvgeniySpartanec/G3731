//ДЗ Задача №2
//Написать программу, которая на вход принимает два числа
//и выдает, какое число больше, а какое меньшее. 
//считываем данные с консоли
string? imputNum1 = Console.ReadLine();
string? imputNum2 = Console.ReadLine();
//проверяем, чтобы данные не были пустыми
if (imputNum1 != null && imputNum2 != null)
{
    //Парсим введенное число
    int number1 = int.Parse(imputNum1);
    int number2 = int.Parse(imputNum2);
    //вводим условие
    if (number1 > number2)
    {
        Console.WriteLine(number1);
    }
    else if (number1 < number2)
    {
        //выводим данные в консоль
        Console.WriteLine(number2);
    }
}





