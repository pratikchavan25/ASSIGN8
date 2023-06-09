// See https://aka.ms/new-console-template for more information
// 8. Write a program to enter temperature in °Celsius and convert it into °Fahrenheit ?

Double celsius, fahrenheit;

Console.WriteLine("enter the temperature in Celsius");
celsius = Convert.ToInt32(Console.ReadLine());

fahrenheit = (celsius * 1.8) + 32;

Console.WriteLine(fahrenheit);
