namespace Command
{
    interface ITaxiCommand
    {
        public void Accept(Path path);
        public void Cancel(Path path);
    }
}