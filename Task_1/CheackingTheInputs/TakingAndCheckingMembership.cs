using System;
using System.Collections.Generic;
using System.Text;

namespace CheackingTheInputs
{
    public class TakingAndCheckingMembership
    {
        bool isValid = false;
        int numberOfChoice;
        public int CheckMembership()
        {
            do
            {
                Console.Write("Choose Membership Type::\n1. Standard\n2.  Premium\n");
                Console.Write("Choice : ");
                string inputChoice = Console.ReadLine();
                if (int.TryParse(inputChoice, out numberOfChoice))
                {
                    if (numberOfChoice == 1 || numberOfChoice == 2)
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

            if (numberOfChoice == 1)
            {
                numberOfChoice = 500;
            }
            else
            {
                numberOfChoice = 700;
            }

            return numberOfChoice;

        }
    }
}
