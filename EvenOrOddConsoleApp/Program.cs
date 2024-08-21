using System.Collections.Generic;

/* Define if a number is even or odd without using % */
string EvenOrOdd(int number)
{
    return ((number - (2 * Convert.ToInt32(number / 2))) == 0 ? "Even" : "Odd");
}

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} is {EvenOrOdd(i)}");
}

//Agora Faça uma função que retorne TRUE, caso um determinado número for ímpar
bool OddNumber(int number)
{
    return number % 2 != 0;
}

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> oddNumbers = numbers.FindAll(OddNumber);

foreach (int number in oddNumbers)
{
    Console.WriteLine(number);
}