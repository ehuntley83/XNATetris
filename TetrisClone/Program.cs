using System;

namespace TetrisClone
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (TetrisClone game = new TetrisClone())
            {
                game.Run();
            }
        }
    }
}

