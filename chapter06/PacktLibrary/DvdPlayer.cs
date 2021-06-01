using static System.Console;

namespace Packt.Shared
{
    public class DvdPlayer : IPlayable
    {
        public void Pause()
        {
            System.Console.WriteLine("Dvd Player is pausing.");
        }

        public void Play()
        {
            System.Console.WriteLine("DVD Player is Playing.");
        }
    }
}
