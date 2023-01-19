// 
//Вариант 1
//считываем данные с консоли//
Console.WriteLine("Введите число:");

string? imputline = Console.ReadLine();
if (imputline == null) {
    Console.WriteLine("День недели не передан");
    Environment.Exit(1);
}
// if (imputline!= null)
// {
//     //создаем массимв с днями недели//
//     string[] dayofweek = new string[7];
//     dayofweek[0] = "понедельник";
//     dayofweek[1] = "вторник";
//     dayofweek[2] = "среда";
//     dayofweek[3] = "четверг";
//     dayofweek[4] = "пятница";
//     dayofweek[5] = "суббота";
//     dayofweek[6] = "воскресенье";
// //Парсим введенное число//
//     int imputNumber = int.Parse(imputline);
//     //находим название дня недели по введенному номеру
//     string outofdayweek = dayofweek[imputNumber - 1];
//     //выводим данные в консоль//
//     Console.WriteLine(outofdayweek);

// }
//Вариант 2
int imputNumber = int.Parse(imputline);
string outDayOfWeek = string.Empty;
switch (imputNumber)
{
    case 1: outDayOfWeek = "Понедельник"; break;
    case 2: outDayOfWeek = "Вторник"; break;
    case 3: outDayOfWeek = "Среда"; break;
    case 4: outDayOfWeek = "Четверг"; break;
    case 5: outDayOfWeek = "Пятница"; break;
    case 6: outDayOfWeek = "Суббота"; break;
    case 7: outDayOfWeek = "Воскресенье"; break;
    default: outDayOfWeek = "Это не понедельник, чувак"; break;
}
Console.WriteLine(outDayOfWeek);

