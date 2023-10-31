namespace Iterator
{
    public interface IBookNumerable
    {
        public IBookIterator CreateNumerator();
        int Count { get; }
        Book this[int index] { get; }
    }
}
