namespace Strategy
{
    class Author
    {
        public readonly string Name;
        public readonly string Post;

        public Author(string Name, string Post)
        {
            this.Name = Name;
            this.Post = Post;
        }

        public override string ToString()
        {
            return $"{Name}. {Post}";
        }
    }
}
