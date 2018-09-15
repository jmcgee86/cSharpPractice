using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"/Users/jmcgee/Documents/cSharp/cSharpPractice/MVA/ExceptionHandling/Example.txt");
                Console.WriteLine(content);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("there was a problem!");
                Console.WriteLine("Make sure the name of the file is correct");              
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("there was a problem!");
                Console.WriteLine("Make sure the directory exists");
            }
            catch(Exception ex)
            {
                Console.WriteLine("there was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //code to finalize, ex:
                    //setting objects to null
                    //closing database connection
                Console.WriteLine("closing application now...");
            }
          
        }
    }
}
