using Strategy_Pattern_CompressImage.Strategy;

Console.WriteLine("Welcome To our App to convert Image");
Console.WriteLine("Plz Select Image Type ");
Console.WriteLine("[1].JPEG ");
Console.WriteLine("[2].PNG ");
Console.WriteLine("[3].GIF ");

int choise;
if (int.TryParse(Console.ReadLine(), out choise))
{
    Loading();
    var context = new ImageContext();
    switch (choise)
    {
        case 1:
            context.SetImageStrategy(new JpegStrategy());
            break;
        case 2:
            context.SetImageStrategy(new PngStrategy());
            break;
        case 3:
            context.SetImageStrategy(new GifStrategy());
            break;
        default:
            context.SetImageStrategy(new InvalidStrategy());
            break;
    }
    context.CompressImage();

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
