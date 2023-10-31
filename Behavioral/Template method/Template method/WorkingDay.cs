using System;

namespace Template_method
{
    class WorkingDay : BaseDay
    {
        protected override void Morning()
        {
            Console.WriteLine("Bad morning");
        }

        protected override void Day()
        {
            Console.WriteLine("Bad day");
        }

        protected override void Evening()
        {
            Console.WriteLine("Bad evening");
        }

        protected override void Night()
        {
            Console.WriteLine("Bad night");
        }
    }
}
