//Задача №5
//напишите программу, которая на вход принимает одно число (N), а на выходе показывает
//все целые числа в промежутке от -N до N
//считываем данные с консоли
string? imputNumLine = Console.ReadLine();
//проверяем, чтобы данные не были пустыми
if(imputNumLine!=null)
{
    //Парсим введенное число
    int imputNumberA = int.Parse(imputNumLine);
    int imputNumberC = imputNumberA*(-1);
    string outNumLine = string.Empty;
    //Задаем условие выполнения цикла
while(imputNumberC < imputNumberA)
    {
        outNumLine = outNumLine + imputNumberC + ",";
        imputNumberC = imputNumberC + 1;
    }
outNumLine = outNumLine + imputNumberA;
//выводим данные в консоль
Console.WriteLine(outNumLine);

}



