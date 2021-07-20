using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Summer2021NavigationDemo
{
    public class Area
    {
        public string Name;
        public string Description;
        public BitmapImage Image = new BitmapImage(new Uri("media/PlaceHolderImage.bmp", UriKind.Relative));
    }
}
