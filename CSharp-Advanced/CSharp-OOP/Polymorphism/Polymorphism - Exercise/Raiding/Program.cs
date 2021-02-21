using Raiding.Core.Contacts;
using System;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
