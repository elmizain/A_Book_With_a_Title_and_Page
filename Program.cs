namespace A_Book_With_A_Title_And_Pages
{
    internal class Program
    {
        class BookInfo
        {
            public string Title { get; set; }
            public int Pages { get; set; }
        }
        static void Main(string[] args)
        {
             object bookObj = new BookInfo
                             {
                                 Title = "C# Basics",
                                 Pages = 250
                             };

            /* Console.WriteLine("========== Question 1 ==========");
                 console.WriteLine(bookObj);*/





            /*Console.WriteLine("\n========== Question 2 ==========");

            BookInfo book = (BookInfo)bookObj;

            Console.WriteLine("ToString(): " + book.ToString());
            Console.WriteLine("Equals(): " + book.Equals(book));
            Console.WriteLine("GetHashCode(): " + book.GetHashCode());
            Console.WriteLine("GetType(): " + book.GetType());*/



            /*  Console.WriteLine("\n========== Question 3 ==========");
              Console.WriteLine("Compile-time Error: You can't assign a string to an int.");
              int pages = 100;
              Console.WriteLine("Fixed Value = " + pages);*/



            /*Console.WriteLine("\n========== Question 4 ==========");

            try
            {
                int x = 10;
                int y = 0;
                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }*/

            /*Console.WriteLine("\n========== Question 5 ==========");

            int pages2 = 300;
            double dPages = pages2;
            Console.WriteLine(dPages);*/


            /* Console.WriteLine("\n========== Question 6 ==========");

             double price = 49.99;
             int intPrice = (int)price;
             Console.WriteLine(intPrice);*/


            /*Console.WriteLine("\n========== Question 7 ==========");

            string pagesText = "464";
            int pagesNumber = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesNumber);*/


            /* Console.WriteLine("\n========== Question 8 ==========");

             string yearText = "2023";
             int year = int.Parse(yearText);
             Console.WriteLine(year);

             string badText = "abc";

             if (int.TryParse(badText, out int result))
             {
                 Console.WriteLine(result);
             }
             else
             {
                 Console.WriteLine("Invalid number");
             }*/



            /*Console.WriteLine("\n========== Question 9 ==========");

            int pages3 = 464;
            string text = pages3.ToString();

            Console.WriteLine(text);
            Console.WriteLine(text.GetType());*/


            /*Console.WriteLine("\n========== Question 10 ==========");

            int copies = 100;

            object obj = copies;      // Boxing

            int newCopies = (int)obj; // Unboxing

            Console.WriteLine("Original: " + copies);
            Console.WriteLine("Unboxed: " + newCopies);*/

            /*Console.WriteLine("\n========== Question 11 ==========");

            int? nullableYear = null;

            Console.WriteLine(nullableYear.HasValue);

            nullableYear = 2023;

            Console.WriteLine(nullableYear.Value);*/


            /*Console.WriteLine("\n========== Question 12 ==========");

            string? reviewer = null;

            Console.WriteLine(reviewer == null);*/



            /* Console.WriteLine("\n========== Question 13 ==========");

             BookInfo? nullBook = null;

             Console.WriteLine(nullBook?.Title);*/

            /*Console.WriteLine("\n========== Question 14 ==========");

            string? title = null;

            Console.WriteLine(title ?? "Untitled");

            title ??= "Untitled";

            Console.WriteLine(title);*/

            Console.WriteLine("\n========== Question 15 ==========");

            string? name = "Ahmed";

            string confirmedName = name!;

            Console.WriteLine(confirmedName);
        }
    }
}
        }
    }
}
