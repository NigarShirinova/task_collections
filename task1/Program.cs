using System;

class Program
{
    public static void Main(string[] args)
    {
        string word = "salam";
        string reversedWord = "";
        Stack<char> stack = new Stack<char>();
        foreach (char c in word)
        {
            stack.Push(c);
        }
        while (stack.Count > 0)
        {
            reversedWord += stack.Pop();
        }
        Console.WriteLine(reversedWord);

    }
}