//Написать программу, которая на входе принимает 2 числа
//и выводит является ли 2е число кратное первому
//если второе число не кратное первому,то программа выводит остаток от деления
int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");
int result = num2%num1;
if(result==0)
{
    Console.WriteLine("Кратное");
}
else
{
Console.WriteLine("Не кратно "+result);
}










