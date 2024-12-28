namespace testStructure
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;

    };




    public class testStructure
    {
        static void Main(string[] args)
        {
            Books Book1;
            Books Book2;

            Book1.title = "C Programming";
            Book1.author = "Nuha Ail";
            Book1.subject = "C Programming Turtorial";
            Book1.book_id = 6495407;

            Book2.title = "Telecom Billing";
            Book2.author = "KENNY";
            Book2.subject = "Telecom Billing Tutorial";
            Book2.book_id = 6495700;
            Console.WriteLine("Book1 title :" + Book1.title);
            Console.WriteLine("Book1 author :" + Book1.author);
            Console.WriteLine("Book1 subject :" + Book1.subject);
            Console.WriteLine("Book1 book_id :" + Book1.book_id);

            Console.WriteLine("Book2 title :" + Book2.title);
            Console.WriteLine("Book2 author :" + Book2.author);
            Console.WriteLine("Book2 subject :" + Book2.subject);
            Console.WriteLine("Book2 book_id :" + Book2.book_id);
            Console.ReadKey();



        }
    }
}
