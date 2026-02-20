Console.WriteLine("This calculator can perform four operations: addition, subtraction, multiplication, and division.");

string userA, userB;
double a,b;
string operation;

Console.WriteLine(" ");
Console.WriteLine("What operation would you like to perform?");
operation = Console.ReadLine();

if (operation != "addition" && operation != "subtraction" && operation != "multiplication" && operation != "division")
{
    Console.WriteLine(" ");
    Console.WriteLine("ERROR");
    Console.WriteLine("This calculator can only perform four operations: addition, subtraction, multiplication, and division.");
    return;
}

Console.WriteLine("What is your first number?");
userA = Console.ReadLine();
a = double.Parse(userA);

Console.WriteLine("What is your second number?");
userB = Console.ReadLine();
b = double.Parse(userB);

double result;


if (operation == "addition")
{
    result = a + b;
    Console.WriteLine(" ");
    Console.WriteLine($"{a}+{b}={result}");
}

else if (operation == "subtraction")
{
    result = a - b;
    Console.WriteLine(" ");
    Console.WriteLine($"{a}-{b}={result}");
}

else if (operation == "multiplication")
{
    result = a * b;
    Console.WriteLine(" ");
    Console.WriteLine($"{a}*{b}={result}");
}

else if (operation == "division")
{
    if (b == 0)
    {
        Console.WriteLine("You cannot divide by 0.");
        return;
    }
    else
        result = a / b;
    Console.WriteLine(" ");
    Console.WriteLine($"{a}/{b}={result}");
}