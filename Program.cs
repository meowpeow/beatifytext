using System;
using System.Linq.Expressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Reader reader = new Reader();
            reader.ReadMan();
        }
    }


    class Reader
    {
        public void ReadMan()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("G:\\CODE4\\text\\economy.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }


    }
}
