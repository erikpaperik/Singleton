using System;
using Singleton.lib;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            String aKey = Configuration.getInstance().getValue("aKey");
            Console.WriteLine($"aKey: {aKey}");

            Configuration.getInstance().setValue("bKey", "1234");
            String bKey = Configuration.getInstance().getValue("bKey");
            Console.WriteLine($"bKey: {bKey}");
            Console.ReadKey();
        }
    }
}
