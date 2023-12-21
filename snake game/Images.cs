using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace snake_game
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource Body = LoadImage("DeadBody.png");
        public readonly static ImageSource Head = LoadImage("DeadHead.png");
        public readonly static ImageSource Food = LoadImage("Food.png");
        public readonly static ImageSource DeadBody = LoadImage("Body.png");
        public readonly static ImageSource DeadHead = LoadImage("Head.png");
        public readonly static ImageSource Food2x = LoadImage("Food2x.jpg");
        public readonly static ImageSource AntiFood = LoadImage("AntiFood.jpg");
        public readonly static ImageSource Special = LoadImage("special.png");
        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative));
        }
    }
}
