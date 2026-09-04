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
            #endregion

            #region 2nd q
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(obj.GetHashCode());
            Console.WriteLine(obj.GetType());
            #endregion
        }

    }
    
}
