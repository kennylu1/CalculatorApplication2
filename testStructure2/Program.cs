namespace testStructure2
{
    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;
        //設定欄位  未來可以直接生成table
        public void setValues(string t, string a, string s, int id)
        {
            title = t; author = a; subject = s; book_id = id;
        }//setValues  給參數給值
        public void display()
        {
            Console.WriteLine($"Title:{title}");
            Console.WriteLine($"author:{author}");
            Console.WriteLine($"subject:{subject}");
            Console.WriteLine($"book_id:{book_id}");

        }
    };
    public class testStructure2
    {
        static void Main(string[] args)
        {   Books Book1 = new Books();
            Books Book2 = new Books();//宣告
            Book1.setValues("C Programming","Nuha Ali", "Telecom Billing Tutorial", 6495407);
            Book2.setValues("Telecom Billing","Zara Ali", "Telecom Billing Tutorial", 6495700);//跑值
            Book1.display();
            Book2.display();//跑上面的方法
            Console.ReadKey();


        }

    }
}


