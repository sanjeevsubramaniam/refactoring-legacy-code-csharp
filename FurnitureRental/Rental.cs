using System;
namespace FurnitureRental
{
	public class Rental
    {

        private readonly int daysRented;
        private readonly Furniture furniture;

        public Rental(Furniture furniture, int daysRented)
        {
            this.furniture = furniture;
            this.daysRented = daysRented;
        }

        public int GetDaysRented()
        {
            return daysRented;
        }

        public Furniture GetFurniture()
        {
            return furniture;
        }
    }
}

