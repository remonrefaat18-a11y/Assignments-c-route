namespace assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            double[] prices = { 25.5, 40.0, 33.75};
            Console.WriteLine(prices[1]);
            #endregion

            #region q2
            int[,] shelfCopies = {
                {3,5 },
                {1,4 }
            };
            Console.WriteLine(shelfCopies[1,0]);
            #endregion

            #region q3
            PrintWelcomeMessage();
            #endregion

            #region q4
            PrintBookTitle("Clean Code");
            #endregion

            #region q5
            int pages = 400;
            Console.WriteLine(pages);
            // i expected output: 450 but the output is still 400 becuse the method makes a new address in stack and the value of pages in main method is not changed
            #endregion

            #region q6
            double[] prices2 = { 25.5, 40.0 };
            ApplyDiscount(prices2);
            Console.WriteLine(prices2[0]);
            //i expected output :20.5 becuse array is reference type and this call is passing by the value of the address so it changes the orignal object in heap
            #endregion

            #region q7
            int pages2 = 400;
            AddBonusPagesByRef(ref pages2);
            Console.WriteLine(pages2);
            //it is calling by the reference of the variable so it changes the value of the original variable in main method
            #endregion

            #region q8
            ReplaceArray(ref prices2);
            Console.WriteLine(prices2.Length);
            #endregion

            #region q9
            double price;
            bool hasPrice1 = TryGetPrice("Clean Code", out price);
            Console.WriteLine(price);
            bool hasPrice2 = TryGetPrice("", out price);
            Console.WriteLine(price);
            #endregion

            #region q10
            PrintBookInfo("clean book");
            PrintBookInfo("clean book", 400);
            #endregion

            #region q11
            PrintBookInfo(pages: 200, title: "clean code");
            #endregion

            #region q12
            PrintAllTitles("clean code", "abc", "ppg");
            #endregion

            Console.ReadLine();
        }
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        public static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book Title: {title}");
        }

        public static void AddBonusPages(int pages)
        {
            pages += 50;
        }

        public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5.0;
        }

        public static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

        public static void ReplaceArray(ref double[] prices)
        {
            double[] newArray = { 10.0, 12.5, 15.0 };
            prices = newArray;
        }

        public static bool TryGetPrice(string title, out double price)
        {
            if(title== "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }

        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"title is {title} and number of pages is {pages}");
        }

        public static void PrintAllTitles(params string[] titles)
        {
            for(int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine(titles[i]);
            }
        }
    }
}
