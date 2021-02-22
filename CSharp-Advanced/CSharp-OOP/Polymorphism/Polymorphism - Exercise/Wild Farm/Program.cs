using System;
using WildFarm.EngineCore;
using WildFarm.EngineCore.Contracts;

namespace WildFarm
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
