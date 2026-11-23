using System;
using System.Collections.Generic;
using System.Text;

namespace CheackingTheInputs
{
    public class TakingAndCheckingGender
    {
        bool isValid = false;
        int numberOfChoice;
        public int CheckGender()
        {
            do
            {
                Console.WriteLine("Choose Gender:\n1. Male\n2. Female\n");
                Console.Write("Choice : ");
                string inputChoice = Console.ReadLine();
                if (int.TryParse(inputChoice, out numberOfChoice))
                {
                    if (numberOfChoice==1 || numberOfChoice == 2)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("The choice should be 1 or 2 only");
                    }
                }
                else
                {
                    Console.WriteLine("The choice must be intger");

                }
            } while (isValid == false);

            return numberOfChoice;

        }
    }
}
