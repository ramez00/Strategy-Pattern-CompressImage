
namespace Strategy_Pattern_CompressImage.Strategy;
public class ImageContext
{
    // The context maintains a reference to one of the strategy objects.
    // The context delegates some work to the strategy object instead of
    // implementing multiple versions of the algorithm on its own.

    private IImageStrategy _imageStrategy;

    public void SetImageStrategy(IImageStrategy imageStrategy)
    {
        _imageStrategy = imageStrategy;
    }
    public void CompressImage()
    {
        _imageStrategy.CompressImage();
    }
}
