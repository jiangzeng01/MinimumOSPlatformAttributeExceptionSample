using System;
using System.Runtime.Versioning;

namespace MinimumOSPlatformAttributeExceptionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            MinimumOSPlatformAttribute OSPlatform = new MinimumOSPlatformAttribute("win-x64");
            Console.WriteLine(OSPlatform.PlatformName);
            Console.WriteLine("Hello World!");
        }
    }
}
