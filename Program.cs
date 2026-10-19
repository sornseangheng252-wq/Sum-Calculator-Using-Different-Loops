using System;
class Program
{
     static void Main(string[ ] args)
    {
        SumUsingForLoop(5);
        SumUsingWhileLoop(5);
        SumUsingDowhileLoop(5);
    }
    static void SumUsingForLoop(int number)
    {
        int sum = 0;
         for(int i = 1; i <= number; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum using for loop: "+sum);
    }
    static void SumUsingWhileLoop(int number)
    {
        int sum = 0;
        int i = 1;
        while (i <= number)
        {
            sum += i;
            i++;
        }
        Console.WriteLine("Sum using while loop:"+sum);
    }
    static void SumUsingDowhileLoop(int number)
    {
        int sum = 0;
        int i = 1;
        do
        {
            sum += i;
            i++;
        } while (i <= number);
        Console.WriteLine("Sum using do while loop:"+sum);
    }
}