string[] animals = {"panda","dog", "penguin", "giraffe"};
string favoriteAnimal = "giraffe";

int i;
i = 0;

bool x;
x = false;

foreach (string animal in animals)
{
    
    if (animal == favoriteAnimal)
    {
        x = true;
        break;
    }
}

if (x == true)
{
    Console.WriteLine("Yay");
}

if (x == false)
{
    Console.WriteLine("Nay");
}