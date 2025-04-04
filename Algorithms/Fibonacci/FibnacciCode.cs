namespace Algorithms.Fibonacci;

public class FibnacciCode
{
    
    public static void RunFibunacci()
    {
        int firstNum = 0;
        int secondNum = 1;
        int n = 20;
        List<int> allNumbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int nextNum = firstNum + secondNum;
            Console.WriteLine(nextNum);
            allNumbers.Append(nextNum);
            firstNum = secondNum;
            secondNum = nextNum;
        }
    }

    public static void RecursiveFibonacci(int num1, int num2, int count)
    {
        
        if (count < 10)
        {
            int newNum = num1 + num2;
            Console.WriteLine(newNum);
            num1 = num2;
            num2 = newNum;
            count += 1;
            RecursiveFibonacci(num1, num2, count);
        }
        else
        {
            return;
        }
    }

    public static int FindNFibonacci(int n)
    {
        Console.WriteLine(n);
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return FindNFibonacci(n - 1) + FindNFibonacci(n - 2);
        }
    }
}