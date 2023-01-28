using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GracefullyHandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                   //system.io.file.readalltext - search engine ex google search
                string content = File.ReadAllText(@"C:\Lesson22\Exampl.txt");
                Console.WriteLine(content);
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the file is name Correctly: Example.txt");
            }
            catch (DirectoryNotFoundException ex) ///the folder name is wrong
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"Make sure the directory C:\Lesson22 exist.");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Code to finalize
                //Setting objects to null
                // Closing database connections
                Console.WriteLine("Closing application now ...");
            }
            Console.ReadLine();
            /* string content = File.ReadAllText(@"C:\Lesson22\Example.txt");
             Console.WriteLine(content);
             Console.ReadLine();*/
        }
    }
}