namespace StringApplication
{
     class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";
            string fullname = fname+ lname;
Console.WriteLine("Full Name: " + fullname);

            char[] letters = { 'H', 'E', 'L', 'L', 'O' };
            String greetings = new string(letters);
            Console.WriteLine("Greetings:"+greetings);
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            String message = String.Join(" ", sarray);
            Console.WriteLine($"Message:{message}" );
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message send at{0:t}on {0:D}", waiting);//這行是不是有其他寫法
            Console.WriteLine($"Message:{chat}");
            Console.ReadKey();





        }
    }
}
