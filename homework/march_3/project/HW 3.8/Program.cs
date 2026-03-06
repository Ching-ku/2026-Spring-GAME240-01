Console.WriteLine("The ninth assignment:");
Console.WriteLine(" ");

int i = 1;

bool isEven = false;

while (i <= 20)
{
    if (isEven)
    {
        Console.WriteLine(i + " is even");
        isEven = false;
    }
    else{
        Console.WriteLine(i + " is odd");
        isEven = true;
    }

    i++;
}