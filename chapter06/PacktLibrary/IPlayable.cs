using static System.Console;

namespace Packt.Shared
{
    public interface IPlayable
    {
        void Play();
        void Pause();
        void Stop(){ //default implementation
            System.Console.WriteLine("Default implementation of Stop");
        }
    }
}