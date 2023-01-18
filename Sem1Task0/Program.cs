// Задача №0
// Написать программу, которая на вход принимает число и выдает его квадрат
//( число умноженное на само себя)
//считываем данные с консоли
string? inputNum = Console.ReadLine();
//проверяем, чтобы данные не были пустыми
if(inputNum!=null)
{
//Парсим введенное число
int number = int.Parse(inputNum);

int result = number*number;
//выводим данные в консоль
Console.WriteLine(result);
}

