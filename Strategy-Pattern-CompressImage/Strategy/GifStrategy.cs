namespace Strategy_Pattern_CompressImage.Strategy;
public class GifStrategy : IImageStrategy
{
    public void CompressImage()
    {
        Console.WriteLine("Compressing image using GIF strategy.");
    }
}
