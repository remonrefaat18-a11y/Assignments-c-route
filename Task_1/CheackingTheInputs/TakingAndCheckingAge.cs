using System;
using System.Collections.Generic;
using System.Text;

namespace CheackingTheInputs
{
    public class TakingAndCheckingAge
    {
        bool isValid = false;
        int intgerAge;
        public int CheckAge()
        {
            do
            {
                Console.Write("Enter Age : ");
                string inputAge = Console.ReadLine();
                if (int.TryParse(inputAge, out intgerAge))
                {
                    if (intgerAge >= 16 && intgerAge <= 50)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("The age should be greater than 16 and samller than 50 ");
                    }
                }
                else
                {
                    Console.WriteLine("The age must be intger");

                }
            } while (isValid == false);
            return intgerAge;
        }
    }
}
