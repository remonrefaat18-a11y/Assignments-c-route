namespace CheackingTheInputs
{
    public class TakingAndCheckingId
    {
        bool isValid = false;
        int intgerId;
        public int CheckId()
        {
            do
            {
                Console.Write("Enter Id: ");
                string inputId = Console.ReadLine();
                if (int.TryParse(inputId, out intgerId))
                {
                    if (intgerId > 0)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("The id should be greater than zero");
                    }
                }
                else
                {
                    Console.WriteLine("The id must be intger");

                }
            } while (isValid == false);
            return intgerId;

        }


    }
}
