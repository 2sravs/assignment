using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = "100";

                int ParsedNumber = int.Parse(input);

                Console.WriteLine("parse number is: \t" + ParsedNumber);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
