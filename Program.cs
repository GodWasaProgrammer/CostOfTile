namespace CostOfTile
{
    public class Program
    {
        const double COSTPERHOUR = 86; // dollars
        const double FLOORINGPERHOUR = 18.580608; // square centimeters ( 20 foot )

        static void Main()
        {
            Console.WriteLine("Welcome to the Tile Cost Processing software");
            bool isParsable;
            double costPerTile;
            do
            {
                Console.WriteLine("enter your cost per tile");
                isParsable = double.TryParse(Console.ReadLine(), out costPerTile);
            }
            while (isParsable == false);

            Console.WriteLine("Pick your floortype, enter the correlating number \n 1. rectangle \n 2. triangle \n 3. circle ");

            int floorType;

            do
            {
                isParsable = Int32.TryParse(Console.ReadLine(), out floorType);

                if ((floorType < 1) || (floorType > 3))
                {
                    Console.WriteLine("That is not a valid option.");
                    isParsable = false;
                }

            }
            while (isParsable == false);

            double floorSize = 0;
            // rectangle 
            if (floorType == 1)
            {
                double length;
                do
                {
                    Console.WriteLine("Enter the height of our rectangle");

                    isParsable = double.TryParse(Console.ReadLine(), out length);
                }
                while (isParsable == false);

                double width;
                do
                {
                    Console.WriteLine("Enter the width of our rectangle");

                    isParsable = double.TryParse(Console.ReadLine(), out width);

                }
                while (isParsable == false);

                floorSize = length * width;
            }
            // herons formula
            if (floorType == 2)

            {
                double sideA;
                Console.WriteLine("Enter your 3 sides of your triangle");
                do
                {
                    Console.WriteLine($"Enter side A");
                    isParsable = double.TryParse(Console.ReadLine(), out sideA);
                }
                while (isParsable == false);

                double sideB;
                do
                {
                    Console.WriteLine($"Enter side B");
                    isParsable = double.TryParse(Console.ReadLine(), out sideB);
                }
                while (isParsable == false);

                double sideC;
                do
                {
                    Console.WriteLine($"Enter side C");
                    isParsable = double.TryParse(Console.ReadLine(), out sideC);
                }
                while (isParsable == false);

                // now that we have our values we will do the calculations

                double s = (sideA + sideB + sideC) / 2;
                floorSize = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            }
            // circles
            if (floorType == 3)
            {
                Console.WriteLine("Would you like to calculate your circle by radius or diameter? enter r for radius, else it will be by diameter.");

                if (Console.ReadLine() == "r")
                {
                    double radius;
                    do
                    {
                        Console.WriteLine("Enter your radius to calculate your floor size");
                        isParsable = double.TryParse(Console.ReadLine(), out radius);
                    }
                    while (isParsable == false);

                    floorSize = Math.PI * (radius *= radius);
                }

                else
                {
                    double diameter;
                    do
                    {
                        Console.WriteLine("Enter your diameter to calculate your circle area by diameter");
                        isParsable = double.TryParse(Console.ReadLine(), out diameter);

                    }
                    while (isParsable == false);

                    floorSize = Math.PI * diameter;
                }

            }

            // the amount of work hours needed for your specified floor.
            double materialCost = floorSize * costPerTile;
            Console.WriteLine($"The Material cost is:{Math.Round(materialCost, 3)} Dollars");

            // hours needed to cover the specified floor with tiles
            double workHours = floorSize / FLOORINGPERHOUR;
            Console.WriteLine($"The amount of work hours needed for your floor: {Math.Round(workHours, 3)}");

            // your wagecost for flooring your specific floor
            double wageCost = workHours * COSTPERHOUR;
            Console.WriteLine($"The cost of the actual flooring: {Math.Round(wageCost, 3)} Dollars");

            // the complete cost of flooring and material
            double totalCost = wageCost + materialCost;
            Console.WriteLine($"Your total cost is:{Math.Round(totalCost, 3)} Dollars");
        }
    }
}