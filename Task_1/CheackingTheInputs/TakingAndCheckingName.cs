using System;
using System.Collections.Generic;
using System.Text;

namespace CheackingTheInputs
{
    public class TakingAndCheckingName
    {
        bool isValid = false;
        string name;
        public string checkName()
        {
           
            do
            {
                Console.Write("Enter the Name: ");
                string inputName = Console.ReadLine();
                if (inputName is null || inputName=="" || int.TryParse(inputName,out _))
                {
                    Console.WriteLine("Enter a valid name");
                }
                else
                {
                    isValid = true;
                    name = inputName;
                }
            } while(isValid == false);
            return name;
        }

    }
}
