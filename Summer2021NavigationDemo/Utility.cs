using System;
using System.Windows.Media.Imaging;


namespace Summer2021NavigationDemo
{
    class Utility
    {
        //public static BitmapImage MakeRelativeImage(string path)
        //{
        //    return new BitmapImage(new Uri(path, UriKind.Relative));
        //}

        //expression-bodied version
        public static BitmapImage MakeRelativeImage(string path) => new BitmapImage(new Uri(path, UriKind.Relative));
 
    }
}
