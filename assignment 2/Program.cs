using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            string title= "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            #endregion

            #region q2
            string title1 = "clean code";
            string title2 = "clean code";
            Console.WriteLine(ReferenceEquals(title1, title2));
            #endregion

            #region q3
            StringBuilder name = new StringBuilder();
            name.Append("Book List");
            name.Append(" - Updated");
            Console.WriteLine(name);
            #endregion

            #region q4
            name.Replace("Book List", "Library");
            Console.WriteLine(name);
            #endregion

            #region q5
            string newTiltle= "clean code";
            int page = 464;
            Console.WriteLine("Book: " + newTiltle + ", Pages: " + page);
            #endregion

            #region q6
            Console.WriteLine($"Book: {newTiltle}, Pages: {page}");
            #endregion

            #region q7
            Console.WriteLine("Book: {0}, Pages: {1}", newTiltle, page);
            #endregion

            #region q8
            int newPage = 464;
            if(newPage > 300)
            {
                Console.WriteLine("long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion

            #region q9
            int newPages1 = 464;
            bool isAvailable = true;
            if(newPages1>300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion

            #region q10
            string title3 = "Refactoring";
            switch (title3)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion

            #region q11
            int pages3 = 464;
            string sizeLabel=pages3>300 ? "long book" : "short book";
            #endregion

            #region q12
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for(int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i+1}.{books[i]}");
            }
            #endregion

            #region q13
            int j = 0;
            while (j < books.Length)
            {
                Console.WriteLine($"{j+1}.{books[j]}");
                j++;
            }
            #endregion

            #region q14
            int i2 = 0;
            do
            {
                Console.WriteLine("Checking book...");
                i2++;
            }
            while (i2 <=2);
            #endregion

            #region q15
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            #endregion

            #region q16
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(book);
            }
            #endregion

            #region q17
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(book);
            }
            #endregion

            #region q18
            PrintFirstBook(books);
            #endregion
            Console.ReadLine();

        }
        static void PrintFirstBook(string[] books)
        {
            if (books.Length == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine(books[0]);
            }


        }
    }
}
