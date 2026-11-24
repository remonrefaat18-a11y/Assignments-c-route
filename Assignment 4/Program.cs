using Assignment_4;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            Book book = new Book();
            //Console.WriteLine(book.password);
            //we cannot reach this field because it is private
            #endregion

            #region q2
            Console.WriteLine(book.copiesInStock);
            //it prints 5 becuse it is internal that is availble inside the project
            #endregion

            #region q3
            book.Title = "claen code";
            Console.WriteLine(book.Title);
            #endregion

            #region q4
            book.genre = Genre.Science;
            Console.WriteLine(book.genre);
            #endregion

            #region q5
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion

            #region q6
            int genreNumber = 1;
            Genre value = (Genre)genreNumber;
            Console.WriteLine(value);
            #endregion

            #region q7
            Genre genre = Genre.Fiction;
            string strGenre = genre.ToString();
            Console.WriteLine(strGenre);
            #endregion

            #region q8
            string genreText = "Science";
            Genre genre1 = (Genre)Enum.Parse(typeof(Genre),genreText);
            Console.WriteLine(genre1);
            #endregion

            #region q9
            string genreText2 = "Mystery";
            bool isGenre = Enum.TryParse(genreText2,out Genre value1);
            if (isGenre)
            {
                Console.WriteLine(value1);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion


        }
    }
}
