using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonar_Sweep
{
    class Program
    {
        static void Main(string[] args)
        {
            //int oxyGenRating = 0;   nice pun NERD
            //int CO2ScrubRating = 0; but i never got to use this, since binary converters already exist. LOL.
            int tempCount = 0; //temporary counter
            char mostCommon = '0';
            char leastCommon = '1';
            
            string[] input = System.IO.File.ReadAllLines(@"C:\Users\natha\OneDrive\Área de Trabalho\Programacao\C#\Sonar Sweep\Sonar Sweep\Input\Gamma and Epsilon.txt");

            for(int i = 0;i < 12 ; i++)
            {
                for(int j = 0; j < input.Length; j++) //checks each column and counts how many zeroes and ones there are
                {
                    if (input[j][i] == '1')
                    {
                        tempCount++;
                    } 
                    else if (input[j][i] == '0')
                    {
                        tempCount--;
                    }
                    System.Console.WriteLine("Input[" + j + "]: "+ input[j] + " - Count: " + tempCount);
                }
                System.Console.WriteLine("\n\n\n\n");

                if (tempCount >= 0) //positive number = more ones and vice versa
                {
                    //mostCommon = '1';
                    leastCommon = '0';
                }

                //System.Console.WriteLine("Least Common number of row " + (i + 1) + ": " + mostCommon);
                System.Console.WriteLine("Least Common number of row " + (i + 1) + ": " + leastCommon);

                for (int j = 0; j < input.Length; j++) //invalidates an input string if it does not match the most common number on that column
                {
                    System.Console.Write(input[j]);
                    //if (input[j][i] == mostCommon){ }
                    if (input[j][i] == leastCommon) { }
                    else 
                    {
                        input[j] = "Deleted String";
                        
                    }
                    System.Console.WriteLine(" -> " + input[j]);

                }

                tempCount = 0;
                //mostCommon = '0';
                leastCommon = '1';
            }

            for (int j = 0; j < input.Length; j++) //searches and prints the the numbers that are left
            {if (input[j] != "Deleted String") { System.Console.WriteLine("Result: " + input[j]); }}


                System.Console.ReadLine();
        }
    }
}
