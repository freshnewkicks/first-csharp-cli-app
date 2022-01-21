using System;

namespace first_csharp_cli_app
{
    class ReadFromFile
    {
        static void Main()
        {
            // read file as one string
            string[] jsonInput = System.IO.File.ReadAllLines(@"C:\Users\Tyler\Desktop\Dev\csharp\first-csharp-cli-app\io-sample-json.json");

            foreach (string lines in jsonInput)
            {
                Console.WriteLine("\t" + lines);
            }

        }
    }
}
