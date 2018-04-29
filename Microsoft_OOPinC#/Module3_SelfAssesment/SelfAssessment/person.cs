using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SelfAssessment
{

    abstract class Person : IDisposable
    {
        private string _firstName;
        private string _lastName;
        private string _sex;
        private int _age;
        public string firstName
        {
            get
            {
                return _firstName;
            } 
            set
            {
                _firstName = value;
            }
        }
        public string lastName
        {
            get
            {
                return _lastName;
            } 
            set
            {
                _lastName = value;
            }
        }

        public string sex 
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }
        }

        public int age 
        {
            get
            {
                return _age;
            } 
            set
            {
                _age = value;
            }
        }

        private bool disposed = false;

        StreamReader sr;
        StreamWriter outputFile;

        public void ReadDetails (string fileName)
        {
            sr = new StreamReader(fileName);

            try
            {
                //open text file using a stream read
                using (sr)
                {
                    //read the stream to a string and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
                sr = null;
            }
        }

        public bool WriteDetails(string fileName)
        {
            bool result = false;
            outputFile = new StreamWriter(fileName);

            //Create a string array with the lines of text
            string [] lines = {this.firstName, this.lastName, this.sex, this.age.ToString()};

            try
            {
                //write the string array to a new file
                using(outputFile)
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
                result = true;
            }

            catch(Exception e)
            {
                Console.WriteLine("This file could not be written");
                Console.WriteLine(e.Message);
                result = false;
            }
            finally
            {
                outputFile.Close();
                outputFile = null;
            }
            return result;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose (bool disposing)
        {
            if(!disposed)
            {
                if (disposing)
                {
                     if (sr != null)
                    {
                        sr.Close();
                    }
                    if( outputFile != null)
                    {
                        outputFile.Close();
                    }
                }
            }

        disposed = true;
        }

        ~Person()
        {
            Dispose(false);
        }


    }
}