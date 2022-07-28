using System.Drawing;
namespace CatEngine.Core
{
    public static class Vector2Extensions
    {
        public static Size Size(this Vector2 v)
        {
            return new Size((int)v.X, (int)v.Y);
        }
    }
}