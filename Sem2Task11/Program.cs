//Написать программу, которая выводит случайное 3х значное число и удаляет второе число

System.Random newSintezator = new System.Random();
int num = newSintezator.Next(100, 1000);

int digitfirst = num / 100;
int digitLast = num % 10;
Console.WriteLine(num);
Console.WriteLine(digitfirst * 10 + digitLast);











