
namespace Strategy_Pattern_CompressImage.Strategy;
public class JpegStrategy : IImageStrategy
{
    public void CompressImage()
    {
        Console.WriteLine("Compressing image using JPEG strategy.");
    }
}   