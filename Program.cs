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





            Console.WriteLine("\n========== Question 2 ==========");

            BookInfo book = (BookInfo)bookObj;

            Console.WriteLine("ToString(): " + book.ToString());
            Console.WriteLine("Equals(): " + book.Equals(book));
            Console.WriteLine("GetHashCode(): " + book.GetHashCode());
            Console.WriteLine("GetType(): " + book.GetType());





        }
    }
}
