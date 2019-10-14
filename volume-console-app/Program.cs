using System;

namespace volume_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "./default_content.txt";
            if (args.Length > 0){
                filePath = args[0];
            }
           

           var text =  System.IO.File.ReadAllText(args[0]);
           Console.WriteLine("Content of file :");
           Console.WriteLine(text); 

        }
    }
}
