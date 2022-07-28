using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatEngine.Core
{

    public class Vector2
    {
        public float X;
        public float Y;

        public Vector2()
        {
            X.Zero();
            Y.Zero();
        }
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public Vector2(int x, int y)
        {
            X = (float)x;
            Y = (float)y;
        }
        public Vector2(object x, object y)
        {
            X = (float)x;
            Y = (float)y;
        }

        /// <summary>
        /// This returns a new Vector2 with both x and y values as 0.
        /// </summary>
        /// <returns></returns>
        public static Vector2 Zero()
        {
            return new Vector2(0, 0);
        }
    }
}