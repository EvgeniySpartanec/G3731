//Задача №7
//Написать программу, которая принимает на вход 3х значное число
//и на выходе показывает последнюю цифру этого числа

//считываем данные с консоли
string? imputNumLine = Console.ReadLine();
//проверяем, чтобы данные не были пустыми
if (imputNumLine != null)
{
    //Парсим введенное число
    int imputNumberA = int.Parse(imputNumLine);
    int lastDigit = imputNumberA % 10;
    //выводим данные в консоль
    Console.WriteLine(lastDigit);
}
