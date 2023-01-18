
// Напишите программу, которая на вход принимает
//число (N), а на выходе показывает все
//чётные числа от 1 до N.
////считываем данные с консоли
string? imputNum1 = Console.ReadLine();
//проверяем, чтобы данные не были пустыми   
if (imputNum1 != null)
{
    //Парсим введенное число
    int N = int.Parse(imputNum1);

    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0)
        {
            //выводим данные в консоль
            Console.WriteLine(Convert.ToString(i));

        }

    }
}







