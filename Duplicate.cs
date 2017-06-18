using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter few numbers separated by a hyphen (-): ");
            var userInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userInput))
                return;

            var listOfNumber = new List<int>();
            foreach (var number in userInput.Split('-'))
                listOfNumber.Add(Convert.ToInt32(number));

            var listOfUnique = new List<int>();
            var isUnique = false;

            foreach (var number in listOfNumber)
            {
                if (!listOfUnique.Contains(number))
                    listOfUnique.Add(number);
                else
                {
                    isUnique = true;
                    break;
                }    
            }

            if (isUnique)
            {
                Console.WriteLine("Duplicate");
                Console.ReadLine();
            }

        }
    }
}
