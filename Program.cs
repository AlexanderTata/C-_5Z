/*Задача 5. Напишите программу, которая на вход принмает число N, а выход все числа от -N до N
-4 -3 -2 -1 0 1 2 3 4*/
//Первое решение

//int number = 4;
//int count = -number;
//while (count <= number)
//{
//    Console.Write(count + "  ");
//    count++;
//}

//Второе решение с модулем Math (математика)

int number = -4;
number = Math.Abs(number);
int count = -number;
while (count <= number)
{
    Console.Write(count + "  ");
    count++;
}