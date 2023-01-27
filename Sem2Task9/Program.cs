System.Random numSintezator = new System.Random();

int rndNum = numSintezator.Next(10, 100);
Console.WriteLine("Случайное число: " + rndNum);

int digit1 = rndNum / 10;
int digit2 = rndNum % 10;

if (digit1 > digit2)
{
    Console.WriteLine("Цифра 1 больше цифры 2: " + digit1 + " " + digit2);
}
else
{
    Console.WriteLine("Цифра 2 больше цифры 1: " + digit1 + " " + digit2);
}










