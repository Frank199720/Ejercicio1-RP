using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaRY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 10, 5, 6, 9, 11, 12 , 11 };
            int inputResult = 11;
            int indexSecondNumber = 0;
            bool keepGoing = true;
            int indexFirstNumber;
            for (indexFirstNumber = 0; indexFirstNumber < numbers.Length && keepGoing; indexFirstNumber++)
            {
                for (indexSecondNumber = indexFirstNumber + 1; indexSecondNumber < numbers.Length; indexSecondNumber++)
                {
                    if (numbers[indexFirstNumber] + numbers[indexSecondNumber] == inputResult)
                    {
                        keepGoing = false;
                        break;
                    }
                }

            }

            if (keepGoing)
            {
                Console.WriteLine("No se encontraron dos numeros que sumen " + inputResult);
                Console.ReadKey();
                
            }
            else
            {
                indexFirstNumber--;
                Console.WriteLine("Array input");
                Console.WriteLine(String.Join("; ", numbers));
                Console.WriteLine("Output");
                              

                Console.WriteLine("Los numeros que suman " + inputResult + " son " + numbers[indexFirstNumber] + " y " + numbers[indexSecondNumber]);
                Console.WriteLine($"Resultado:  [{indexFirstNumber}, {indexSecondNumber}]");
                Console.ReadKey();
            }


            

        }

        
    }
}
