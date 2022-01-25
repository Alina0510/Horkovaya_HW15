using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Player : IRecodable, IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Player is playing");
        }
        public void Stop()
        {
            Console.WriteLine("Player is stopped");
        }
        public void Record()
        {
            Console.WriteLine("Player is recording");
        }
        public void Pause()
        {
            Console.WriteLine("Player is paused");
        }
    }
}
