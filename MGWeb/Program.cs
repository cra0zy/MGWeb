using System;

namespace MGWeb
{
    static class Program
    {
        private static Game1 game;

		static void Main(string[] args)
        {
            game = new Game1();
            game.Run();
        }
    }
}

