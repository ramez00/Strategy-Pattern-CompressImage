
namespace Strategy_Pattern_CompressImage.Strategy;
public class PngStrategy : IImageStrategy
{
    public void CompressImage()
    {
        Console.WriteLine("Compressing image using PNG strategy.");
    }
}
