using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Record();
            player.Play();
            player.Pause();
            player.Stop();
            Console.ReadKey();
        }
    }
}
