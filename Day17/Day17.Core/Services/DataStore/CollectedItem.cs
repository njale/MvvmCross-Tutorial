using System;
using SQLite;

namespace Day17.Core.Services.DataStore
{
    public class CollectedItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Caption { get; set; }
        public string Notes { get; set; }

        public DateTime WhenUtc { get; set; }

        public bool LocationKnown => Latitude != null && Longitude != null;
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public string ImagePath { get; set; }
    }
}
