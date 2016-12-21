using SQLite;

namespace Day10.Core.Services
{
    public class Kitten
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Price})";
        }
    }
}
