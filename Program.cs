using System;
using System.IO;
using System.Text;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start...");

            string path ="D:\\ArchiveValues.json";
          

            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(path))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize)) {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.Write(line);
                    Console.ReadLine();
                }
            }

        }
    }
}
