
namespace Strategy_Pattern_CompressImage.Strategy;
public class InvalidStrategy : IImageStrategy
{
    public void CompressImage()
    {
        Console.WriteLine("Invalid strategy selected.");
    }
}
