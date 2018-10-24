using Xamarin.Forms;

namespace GlideX_HorizontalOptions_Repro
{
    public class MainPage : ContentPage
    {
        const string _xamarinImageUrl = "https://raw.githubusercontent.com/github/explore/06da849e137507b144448ac2b28bc19d3b909cab/topics/xamarin/xamarin.png";

        public MainPage()
        {
            var brokenImage = new XamarinLogoImage
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var workingImage = new XamarinLogoImage();

            Content = brokenImage;
        }

        class XamarinLogoImage : Image
        {
            public XamarinLogoImage()
            {
                BackgroundColor = Color.Black;
                Source = _xamarinImageUrl;
            }
        }
    }
}
