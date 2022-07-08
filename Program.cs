// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 * 03 Object-Oriented Programming
Test your knowledge
1. What are the six combinations of access modifier keywords and what do they do? 2.
What is the difference between the static, const, and readonly keywords when applied to
a type member?

public: the type can be accessed by any other code.
private: The type can be accessed only by code in the same class or struct.
protected: A protected variable may only be acces by code within the same class or derived class
internal: If something is internal it can be access from code withing the same compulation.
protected internal: may be acces by any code where it is declared or inside a derived class.
private protected: may be accessed by types derived from the classes that were declared inside the same compilation.

3. What does a constructor do?

A constructor initializes an object when the new keyword is used and sets values if the constructor it 
takes in parameters. If a constructor is not specified a defualt on is still called. 

4. Why is the partial keyword useful?

The partial keyword is useful because it allows the difinition of a class, a struct, an interface or a method
over multiple differnt source files. This is useful for orgnization purposes.

5. What is a tuple?

A Tuple is a data structure which consists of multiple parts. For example if you want to keep an
integer anad string tied together a good option would be a touple.

6. What does the C# record keyword do?

A record is a new refernece type that uses value based equality. Typically used where you 
might typically use the keywords class or struct.

7. What does overloading and overriding mean?

Overloading is when mupltiple functions with the same name but differnt types or number
of parameters are used inorder to handle differnet situations.
Overriding is when a child changes the functionalilty of a method it inherited from a 
parent class.

8. What is the difference between a field and a property?

Properties provide a level of abstraction which allows you to change the filds in constrolled manner.
A field is just a variable declared within a class.


9. How do you make a method parameter optional?

Use the params keyword in front of the paramter when defining it inorder to make a 
method parameter optional.

10. What is an interface and how is it different from abstract class?

An interface only allows you to define what methods are needed but not implement it.
A class that inherits from an interface must implement all the defined methods. Abstract classes
may define functionalilty.

11. What accessibility level are members of an interface?

members of an interface have public accessibility level.

12. True/False. Polymorphism allows derived classes to provide different implementations
of the same method.

TRUE

13. True/False. The override keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.

TRUE

14. True/False. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.

FALSE
The new keyword is used for method hiding. 

15. True/False. Abstract methods can be used in a normal (non-abstract) class.

FALSE

16.True/False. Normal (non-abstract) methods can be used in an abstract class. 

TRUE

17. True/False. Derived classes can override methods that were virtual in the base class.
TRUE
18. True/False. Derived classes can override methods that were abstract in the base class.
TRUE
19. True/False.In a derived class, you can override a method that was neither virtual non abstract in the
base class.

FALSE

20. True/False. A class that implements an interface does not have to provide an
implementation for all of the members of the interface.

FALSE

21. True/False. A class that implements an interface is allowed to have other members that
aren’t defined in the interface.

TRUE
22. True/False. A class can have more than one base class.

FALSE

23. True/False. A class can implement more than one interface.

TRUE
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

