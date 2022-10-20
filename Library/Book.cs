using System.Xml.Linq;

namespace Library
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int Year { get; set; }
        public int Id { get;} = generateID();

        public override string? ToString()
        {
            if (string.IsNullOrEmpty(Title))
                return base.ToString();
            return Title;
        }

        private static int generateID()
        {
            int id = (int)((DateTime.Now.Ticks / 10) % 1000000000);

            return id;
        }
    }
}