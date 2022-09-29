using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string resultString = "";
            string resultString2 = "";


            {
                foreach (string s in stringArray)
                {
                    resultString += s.Substring(0, 1).ToLower()+  s.Substring(1);

                }
                foreach (char c in resultString) 
                {
                    resultString2 = c + resultString2;
                }
                if (resultString == resultString2)
                {
                    Console.WriteLine("Палиндром");

                }
                else 
                {
                    Console.WriteLine("Не палиндром");
                }
            }
            Console.ReadKey();

            
            
        

        }
    }
}
