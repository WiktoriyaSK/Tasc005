﻿// zадача 2: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные,
//и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] array = new int[12];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " "); 
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
    array[j] = array[j] * -1;
    Console.Write(array[j]+ " ");
}