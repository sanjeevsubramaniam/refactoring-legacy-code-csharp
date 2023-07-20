using System;
namespace FurnitureRental
{
    public class Customer
    {
        private readonly string name;
        private readonly List<Rental> rentals = new();

        public Customer(string name)
        {
            this.name = name;
        }

        public void AddRental(Rental arg)
        {
            rentals.Add(arg);
        }

        public string GetName()
        {
            return name;
        }

        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            String result = "Rental Record for " + GetName() + "\n";
            foreach (Rental each in rentals)
            {
                double thisAmount = 0;
                //determine amounts for each line
                switch (each.GetFurniture().GetPriceCode())
                {
                    case Furniture.REGULAR:
                        thisAmount += 200;
                        if (each.GetDaysRented() > 2)
                            thisAmount += (each.GetDaysRented() - 2) * 150;
                        break;
                    case Furniture.NEW_LAUNCH:
                        thisAmount += each.GetDaysRented() * 300;
                        break;
                    case Furniture.CHILDREN:
                        thisAmount += 150;
                        if (each.GetDaysRented() > 3)
                            thisAmount += (each.GetDaysRented() - 3) * 150;
                        break;
                }
                // add frequent renter points
                frequentRenterPoints++;
                // add bonus for a two days new launch rental
                if ((each.GetFurniture().GetPriceCode() == Furniture.NEW_LAUNCH)
                        &&
                        each.GetDaysRented() > 1) frequentRenterPoints++;

                //show figures for this rental
                result += "\t" + each.GetFurniture().GetTitle() + "\t" +
                        thisAmount + "\n";
                totalAmount += thisAmount;
            }

            //add footer lines result
            result += "Amount owed is " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints
                    + " frequent renter points";
            return result;
        }
    }

}

