using System;
using System.IO;

namespace FileHandling
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //practicing file handling
            //using filestream
            using (FileStream fileStream = new FileStream(@"C:\Users\stuti.shahu\Desktop\Training\2445-Stuti-Feb22\.NetCore\Day10\Practice\Practice1\Source\FileHandling\TestFile.txt", FileMode.Append, FileAccess.Write)) //filemode.open= system should open existing a file   filemode.append=creates a file if it wasnt there
            {
                Console.WriteLine("ENTER YOUR NAME");
                var name = Console.ReadLine();
              //filestream.write only writes bytes, thus we will have to make a constant to write it through it
              using(StreamWriter sw= new StreamWriter(fileStream))
                {
                    sw.WriteLine($"Your name is {name}");
                }
            }
            Console.WriteLine("FILE IS WRITTEN");

            //using the seek function

            Console.WriteLine("USING THE SEEK FUNCTION");
            using(FileStream fileStream = new FileStream(@"C:\Users\stuti.shahu\Desktop\Training\2445-Stuti-Feb22\.NetCore\Day10\Practice\Practice1\Source\FileHandling\TestFile.txt", FileMode.Append, FileAccess.Write))
            {
                Console.WriteLine("ENTER YOUR NAME");
                var name1 = Console.ReadLine();
                fileStream.Seek(5, SeekOrigin.End);
                using(StreamWriter sw = new StreamWriter(fileStream))
                {
                    sw.WriteLine($" This name will be printed with 5 spaces: {name1}");

                }
            }
            Console.WriteLine("CHECK YOUR FILE FOR UPDATES");

        }
    }
}
