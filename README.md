Função que retorna TRUE, caso um determinado número for ímpar.
<code>
bool OddNumber(int number)
{
   return number % 2 != 0;
}
</code>

List numbers = new List { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List oddNumbers = numbers.FindAll(OddNumber);
<code>
foreach (int number in oddNumbers)
{
   Console.WriteLine(number);
}
</code>

Define if a number is even or odd without using %
<code>
string EvenOrOdd(int number)
{
   return ( (number - (2 * Convert.ToInt32(number / 2))) == 0 ? "Even" : "Odd");
}

for (int i = 1; i = 10; i++)
{
   return Console.WriteLine($"{i} is {EvenOrOdd(i)}");
}
</code>
