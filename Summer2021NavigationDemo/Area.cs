using System;
using System.Windows.Media.Imaging;
using static Summer2021NavigationDemo.Utility;

namespace Summer2021NavigationDemo
{
    public class Area
    {
        public string Name;
        public string Description;
        public BitmapImage Image = MakeRelativeImage("media/PlaceHolderImage.bmp");
    }
}
