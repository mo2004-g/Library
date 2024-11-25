namespace task_3
{
    class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public decimal Ispn { get; set; }

    }
    class library
    {
        public library(decimal id, string name, string discrabtion)
        {
            Id = id;
            Name = name;
            Books = new List<Book>();
            Discrabtion = discrabtion;
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Discrabtion { get; set; }
        public List<Book> Books { get; set; }

        public bool searcbytitle(string name)
        {
            if (Name == name)
            {
                Books.Add(new Book() { Author = Discrabtion, Title = Name, Ispn = Id });


                return true;
            }
            else
            {
                Console.WriteLine("NO");
                return false;
            }

        }
       

        
        public bool BorrowBook(string name)
        {
            if (Name == name)
            {
                Console.WriteLine("This book is Availability");
                Console.WriteLine($"you can Borrow {Name} ");
                return true;
            }
            else
            {
                Console.WriteLine("This book is not in the library");
                return false;
            }


        }
        public bool ReturnBook(string name)
        {
            if (Name == name)
            {
                Console.WriteLine(" This book is not borrowed");
                return true;
            }
            
        
            else
            {
                Console.WriteLine($"you can return the {name} ");
                Console.WriteLine("Thanks for your honesty ");

                return false;
            }
                
        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            library b1 = new library(9780743273565, "The Great Gatsby", "F. Scott Fitzgerald");
            library b2 = new library(9780061120084, "To Kill a Mockingbird", "Harper Lee");
            library b3 = new library(9780451524935, "1984", "George Orwell");
            Console.WriteLine(b1.Name);
            Console.WriteLine("=================");
            b1.searcbytitle("The Great Gatsby");
            for(int i = 0; i < b1.Books.Count; i++)
            {
                Console.WriteLine($"The Author :{b1.Books[i].Author}");
                Console.WriteLine($"Title of book :{b1.Books[i].Title}");
                Console.WriteLine($"The ISPN :{b1.Books[i].Ispn}");
                Console.WriteLine("================");
            }
            b1.BorrowBook("The Great Gatsby");
            Console.WriteLine("================");
            b2.ReturnBook("kk");
            Console.WriteLine("========");
            



        }
    }
}
