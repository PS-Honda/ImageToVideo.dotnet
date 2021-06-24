using System;

namespace ImageToVideo.dotnet
{
    class Program
    {
        static ImageConverter fx;
        static void Main(string[] args)
        {
            fx = new ImageConverter();
            var path = fx.Convert();
            Console.WriteLine("Video path : ", path);
            var x = Console.ReadKey();
        }
    }
}
