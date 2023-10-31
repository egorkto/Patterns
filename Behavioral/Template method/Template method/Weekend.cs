using System;

namespace Template_method
{
    class Weekend : BaseDay
    {
        protected override void Morning()
        {
            Console.WriteLine("Good morning");
        }

        protected override void Day()
        {
            Console.WriteLine("Good day");
        }

        protected override void Evening()
        {
            Console.WriteLine("Good evening");
        }

        protected override void Night()
        {
            Console.WriteLine("Good night");
        }
    }
}
