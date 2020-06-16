using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            // Write your code here!
            try
            {
                if (y <= 0)
                {
                    throw new ArgumentOutOfRangeException("Total possible points must be above zero.");
                }
            }
            catch (ArgumentOutOfRangeException notAboveZero)
            {
                Console.WriteLine(notAboveZero.Message);
            }
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            string points = fileName;
            if (fileName == null || fileName == "")
            {
                throw new ArgumentNullException("Must contain a value.");
            }
            else
            {
                if (points.EndsWith(".cs") == true)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            //double dividend = Divide(4, -4);
            //Console.WriteLine(dividend);

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            students.Add("Logan", "WrongProgram.cd");
                   
            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    Console.WriteLine($"Name: {student.Key}, File: {student.Value} Grade: {CheckFileExtension(student.Value)}");
                }
                catch (ArgumentNullException error)
                {
                    Console.WriteLine($"Name: {student.Key}, File: {error.Message}");
                }
            }
        }
    }
}
