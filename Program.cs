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
           

        Console.WriteLine("========== Question 1 ==========");

            object bookObj = new BookInfo
            {
                Title = "C# Basics",
                Pages = 250
            };

            Console.WriteLine(bookObj);
        }
    }
}
