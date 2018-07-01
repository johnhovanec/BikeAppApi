using System;
namespace BikeAppApi.Models
{
    public enum BikeType { Mountain, Road, Hybrid, Commuter, Kids }

    public class Product
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public BikeType type { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int QuantityAvailable { get; set; }

        public string ImagePath { get; set; }
    }
}
