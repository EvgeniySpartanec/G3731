//Напишите программу, которая на вход принимает
// число и выдаёт, является ли число чётным
//считываем данные с консоли
string? imputNum = Console.ReadLine();
//проверяем, чтобы данные не были пустыми
if(imputNum!= null)
{
    //Парсим введенное число
    int number = int.Parse(imputNum);
//Задаем условие
    if(number % 2 == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}








