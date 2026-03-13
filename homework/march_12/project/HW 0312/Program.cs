int [] numbers = {1,2,8,103,10,268};
int smallest = numbers[0];
int biggest = numbers[0];

int index = 0;

while (index < numbers.Length)
{
    if (numbers[index] < smallest)
    {
        smallest = numbers[index];
    }

    if (numbers[index] > biggest)
    {
        biggest = numbers[index];
    }

    index++;
}

Console.WriteLine("The largest number is " + biggest);
Console.WriteLine("The smallest number is " + smallest);