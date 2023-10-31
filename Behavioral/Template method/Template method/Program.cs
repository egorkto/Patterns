namespace Template_method
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDay day = new WorkingDay();
            day.GetRoutine();
        }
    }
}
