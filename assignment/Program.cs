using System;

class SumOfNaturalNumbers
{
    public void Run()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++) sum += i;
        Console.WriteLine("Sum = " + sum);
    }
}

class MultiplicationTable
{
    public void Run()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++) Console.WriteLine($"{n} x {i} = {n * i}");
    }
}

class FactorialCalculator
{
    public void Run()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        int i = 1;
        while (i <= n) { fact *= i; i++; }
        Console.WriteLine("Factorial = " + fact);
    }
}

class ReverseNumber
{
    public void Run()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int rev = 0;
        while (n != 0)
        {
            rev = rev * 10 + n % 10;
            n /= 10;
        }
        Console.WriteLine("Reversed = " + rev);
    }
}

class ArrayMaxMin
{
    public void Run()
    {
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = arr[0], min = arr[0];
        for (int i = 1; i < 10; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
        Console.WriteLine($"Max = {max}, Min = {min}");
    }
}

class ArrayEvenOdd
{
    public void Run()
    {
        int[] arr = new int[10];
        int even = 0, odd = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        foreach (int n in arr)
        {
            if (n % 2 == 0) even++; else odd++;
        }
        Console.WriteLine($"Even: {even}, Odd: {odd}");
    }
}

class SearchElement
{
    public void Run()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.Write("Enter target: ");
        int target = Convert.ToInt32(Console.ReadLine());
        int index = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target) { index = i; break; }
        }
        if (index != -1) Console.WriteLine($"Element found at index {index}");
        else Console.WriteLine("Element not found");
    }
}

class SimpleCalculator
{
    public void Run()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());
        switch (op)
        {
            case '+': Console.WriteLine("Result = " + (a + b)); break;
            case '-': Console.WriteLine("Result = " + (a - b)); break;
            case '*': Console.WriteLine("Result = " + (a * b)); break;
            case '/': Console.WriteLine("Result = " + (b != 0 ? a / b : double.NaN)); break;
            default: Console.WriteLine("Invalid operator"); break;
        }
    }
}

class GradeEvaluator
{
    public void Run()
    {
        Console.Write("Enter marks (0–100): ");
        int marks = Convert.ToInt32(Console.ReadLine());
        if (marks >= 85) Console.WriteLine("Grade: A");
        else if (marks >= 70) Console.WriteLine("Grade: B");
        else if (marks >= 55) Console.WriteLine("Grade: C");
        else if (marks >= 40) Console.WriteLine("Grade: D");
        else Console.WriteLine("Grade: F");
    }
}

class SumUsingWhile
{
    public void Run()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0, i = 1;
        while (i <= n) { sum += i; i++; }
        Console.WriteLine("Sum = " + sum);
    }
}

class Program
{
    static void Main()
    {       
        SimpleCalculator s=new SimpleCalculator();
        s.Run();
    }
}
