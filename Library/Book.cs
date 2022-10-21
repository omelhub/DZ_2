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

            //int id = Guid.NewGuid().GetHashCode();

            /*Алгоритм GUID от Microsoft больше не использует MAC-адрес компьютера — GUID
              фактически генерируются с помощью генератора псевдослучайных чисел(на основе значений времени),
              поэтому, если вам нужно случайное целое число, имеет смысл использовать Randomдля этого класс.
              на самом деле использование GUID для генерации int, вероятно, будет хуже, чем простое использование Random(«хуже» в том смысле,
              что это с большей вероятностью приведет к коллизиям). Это связано с тем, что не все 128 бит в GUID являются случайными.*/

            return id;
        }
    }
}