using System.Windows.Forms;
using System.Drawing;
using System;
using System.Threading;

namespace CatEngine.Core
{
    class Canvas : Form
    {
        public Canvas()
        {
            this.DoubleBuffered = true;
        }
    }
    
    public abstract class CatEngine
    {
        private Vector2 ScreenSize = new Vector2(512, 512);
        private string Title = "New Game";
        private Canvas? Window = null;
        private Thread? GameLoopThread = null;
        public CatEngine(Vector2 screenSize, string title)
        {
            ScreenSize = screenSize;
            Title = title;

            Window = new Canvas();
            Window.Size = ScreenSize.Size();
            Window.Text = Title;
            Window.Paint += Renderer;

            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.Start();

            Application.Run(Window);
        }

        void GameLoop()
        {
            Load();
            while (GameLoopThread.IsAlive)
            {
                try 
                { 
                    Draw();
                    Window.BeginInvoke((MethodInvoker)delegate {Window.Refresh();});
                    Update();
                    Thread.Sleep(1);
                }
                catch
                {
                    System.Console.WriteLine("Game is loading...");
                }
            }
        }

        private void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }

        public abstract void Load();
        public abstract void Update();
        public abstract void Draw();

    }
}