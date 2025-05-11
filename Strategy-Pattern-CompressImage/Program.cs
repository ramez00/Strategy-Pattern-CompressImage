Console.WriteLine("Welcome To our App to convert Image");
Console.WriteLine("Plz Select Image Type ");
Console.WriteLine("[1].JPEG ");
Console.WriteLine("[2].PNG ");
Console.WriteLine("[3].GIF ");

int choise;
if (int.TryParse(Console.ReadLine(), out choise))
{
    Loading(); 
    switch (choise)
    {
        case 1:
            Console.WriteLine("You have selected JPEG");
            break;
        case 2:
            Console.WriteLine("You have selected PNG");
            break;
        case 3:
            Console.WriteLine("You have selected GIF");
            break;
        default:
            Console.WriteLine("Invalid selection");
            break;
    }
}

void Loading()
{
    Console.Write("Loading...");
    for (int i = 0; i < 10; i++)
    {
        Console.Write(".");
        Thread.Sleep(500);
    }
    Console.WriteLine();
}
