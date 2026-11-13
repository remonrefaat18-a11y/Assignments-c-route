namespace assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first part of the assignment
            Console.WriteLine("1- book class");
            Book book = new Book("c#", 180);
            Console.WriteLine(book);
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            Console.WriteLine("==================================================");
            //second part of the assignment
            Console.WriteLine("2- compile time error");
            Console.WriteLine("it is compile time error");
            int pages = 464;
            Console.WriteLine("the correction is\n int pages = 464;");
            Console.WriteLine("==================================================");
            //Third part of the assignment
            Console.WriteLine("3- try catch finally");
            try
            {
                int x = 10;
                int y = 0;
                int z = x / y;
            }
            catch (Exception)
            {
                Console.WriteLine("cant divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            Console.WriteLine("==================================================");
            //forth part of the assignment
            Console.WriteLine("5- casting , conversions , Parsing , ToString() and boxing");

            // implicit casting
            int pages2 = 400;
            double doublePages = pages2;

            // explicit casting
            double price = 49.99;
            int castedPrice = (int)price;

            // conversions
            string pagesText = "464";
            int convertedPagesText=Convert.ToInt32(pagesText);

            // parsing
            string yearText = "2023";
            int parsedYearText = int.Parse(yearText);

            // TryParse
            string badText = "abc";
            bool isParsedBadText=int.TryParse(badText,out int result);
            if (isParsedBadText)
            {
                Console.WriteLine($"Parsed value: {result}");
            }
            else
            {
                Console.WriteLine("invalid number");
            }

            // ToString()
            int pages3 = 464;
            string pagesString = pages3.ToString();
            Console.WriteLine(pagesString.GetType());

            // Boxing and unboxing
            int copies = 100;
            object boxedCopies = copies;
            int unboxedCopies = (int)boxedCopies;
            Console.WriteLine(boxedCopies);
            Console.WriteLine(unboxedCopies);
            Console.WriteLine("==================================================");
            //fifth part of the assignment
            Console.WriteLine("? , ?? and !");

            //nullable int
            int? year = null;
            Console.WriteLine(year.HasValue);
            year = 2023;
            Console.WriteLine(year);

            //nullable string
            string? reviewer = null;
            try
            {
                Console.WriteLine(reviewer.Length);

            }
            catch (Exception)
            {
                Console.WriteLine("reviewer is null");
            }


            //nullable class
            Book? book2 = null;
            try
            {
                Console.WriteLine(book2.title);

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("book2Title is null");
            }

            Console.WriteLine(book2?.title?? "untitled");
            book2?.title ??= "untitled";
            
            //sure non nullable string
            string? name = "ahmed";
            string confirmedName = name!;
            Console.ReadLine();

        }
    }
    public class Book
    {
        public string title;
        public int pages;
        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
        }

    }
}
