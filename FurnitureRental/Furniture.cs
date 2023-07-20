using System;
namespace FurnitureRental
{
	public class Furniture
    {
        public const int REGULAR = 0;
        public const int NEW_LAUNCH = 1;
        public const int CHILDREN = 2;

        private readonly string title;
        private int priceCode;

        public Furniture(string title, int priceCode)
        {
            this.title = title;
            this.priceCode = priceCode;
        }

        public int GetPriceCode()
        {
            return priceCode;
        }

        public void SetPriceCode(int arg)
        {
            priceCode = arg;
        }

        public String GetTitle()
        {
            return title;
        }

    }
}

