// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 * 03 Object-Oriented Programming
Test your knowledge
1. What are the six combinations of access modifier keywords and what do they do? 2.
What is the difference between the static, const, and readonly keywords when applied to
a type member?
3. What does a constructor do?
4. Why is the partial keyword useful?
5. What is a tuple?
6. What does the C# record keyword do?
7. What does overloading and overriding mean?
8. What is the difference between a field and a property?
9. How do you make a method parameter optional?
10. What is an interface and how is it different from abstract class?
11. What accessibility level are members of an interface?
12. True/False. Polymorphism allows derived classes to provide different implementations
of the same method.
13. True/False. The override keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
14. True/False. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
15. True/False. Abstract methods can be used in a normal (non-abstract) class. 16.
True/False. Normal (non-abstract) methods can be used in an abstract class. 17. True/False.
Derived classes can override methods that were virtual in the base class. 18. True/False.
Derived classes can override methods that were abstract in the base class. 19. True/False.
In a derived class, you can override a method that was neither virtual non abstract in the
base class.
20. True/False. A class that implements an interface does not have to provide an
implementation for all of the members of the interface.
21. True/False. A class that implements an interface is allowed to have other members that
aren’t defined in the interface.
22. True/False. A class can have more than one base class.
23. True/False. A class can implement more than one interface.
 */

static int[] GenerateNumbers()
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    return numbers;
}

static int[] Reverse(int[] numbers)
{
    Array.Reverse(numbers);
    return numbers; 
}

static void PrintNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

    int[] numbers = GenerateNumbers();
    Reverse(numbers);
    PrintNumbers(numbers);

static int Fibonacci(int n)
{
    if (n == 0)
    {
        return 0;
    }//To return the first Fibonacci number   
    if (n == 1)
    {
        return 1; //To return the second Fibonacci number
    }
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

static void printFibonacci(int num)
{
    Console.WriteLine("Fibonacci sequence of " + num + ":");

    for(int i = 0; i < num; i++)
    {
        Console.Write(Fibonacci(i)  + ", ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

printFibonacci(8);
printFibonacci(10);
printFibonacci(21);

