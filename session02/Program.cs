using System.Globalization;

namespace session02
{
    internal class Program
    {
        #region 1st q
        class Book
        {
          public  string title;
            public int pages;
         

        }
        static void Main(string[] args)
        {
            Book book=new Book();
            book.title = "c# basics";
            book.pages = 500;

            object obj = book;
            Console.WriteLine(obj);
      
        }
        #endregion
    }
}
