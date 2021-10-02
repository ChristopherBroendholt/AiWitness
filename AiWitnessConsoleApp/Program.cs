using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AiWitnessBaseLibrary;

namespace AiWitnessConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] paths = FileHandling.GetFilePaths();
            FileHandling.GetFileNames();
            

            Video video = new Video(paths[0],true);
            video.GetByteData();

            Console.ReadLine();
        }
    }
}
