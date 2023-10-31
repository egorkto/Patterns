using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "text";
            FileWriter writer = new FileWriter("Test");

            while(true)
            {
                Console.Clear();
                Console.WriteLine("Enter your messange: ");

                var userMessange = Console.ReadLine();

                Console.WriteLine("1 - Write with date\n2 - Write with author\n3 - Clear file\n4 - Quit");
                Console.WriteLine("Enter your choose: ");

                var userChoose = Convert.ToInt32(Console.ReadLine());

                switch(userChoose)
                {
                    case 1:
                        writer.Write(new FileWriterWithDate(), userMessange);
                        break;

                    case 2:
                        Console.WriteLine("Enter author's name: ");

                        var name = Console.ReadLine();

                        Console.WriteLine("Enter author's post: ");

                        var post = Console.ReadLine();

                        var author = new Author(name, post);
                        writer.Write(new FileWriterWithAuthor(author), userMessange);
                        break;

                    case 3:
                        writer.ClearFile();
                        break;
                }

                if(userChoose == 4)
                {
                    break;
                }
            }
        }
    }
}
