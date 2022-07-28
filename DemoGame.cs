using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatEngine.Core;

namespace CatEngine
{
    public class DemoGame : Core.CatEngine
    {
        public DemoGame() : base(new Vector2(512, 512), "CatEngine Demo"){}

        public override void Draw()
        {

        }

        public override void Load()
        {
            System.Console.WriteLine("Loading Demo Game...");
        }
        int frameCount = 0;
        public override void Update()
        {
            System.Console.WriteLine(frameCount);
            frameCount++;
        }
    }
}