namespace CostOfTile
{
    public class Program
    {
        const decimal COSTPERHOUR = 86; // dollars
        const decimal FLOORINGPERHOUR = 18.580608M; // square centimeters ( 20 foot )

        static void Main()
        {
            decimal costPerTile;

            Console.WriteLine("Welcome to the Tile Cost Processing software");
            bool isParsable;
            do
            {
                Console.WriteLine("enter your cost per tile");
                isParsable = decimal.TryParse(Console.ReadLine(), out costPerTile);

                if (isParsable == false)
                {
                    Console.WriteLine("Could not parse. try again");
                }

                if (isParsable)
                {
                    if (costPerTile == 0)
                    {
                        Console.WriteLine("You entered 0 or nothing, try again");
                        isParsable = false;
                    }

                    if (costPerTile < 0)
                    {
                        Console.WriteLine("No negative numbers. try again");
                        isParsable = false;
                    }

                }

            }
            while (isParsable == false);

            Console.WriteLine("Pick your floortype, enter the correlating number \n 1. rectangle \n 2. triangle \n 3. circle ");

            int floorType;

            do
            {
                isParsable = Int32.TryParse(Console.ReadLine(), out floorType);
                if (floorType != 1 && floorType != 2 && floorType != 3)
                {
                    Console.WriteLine("That is not a valid option.");
                    isParsable = false;
                }

            }
            while (isParsable == false);

            decimal floorSize = 0;
            // rectangle 
            if (floorType == 1)
            {

                decimal length;
                do
                {
                    Console.WriteLine("Enter the height of our rectangle");

                    isParsable = decimal.TryParse(Console.ReadLine(), out length);

                    if (isParsable == false)
                    {
                        Console.WriteLine("Could not parse. try again");
                    }

                    if (isParsable)
                    {
                        if (length < 0)
                        {
                            Console.WriteLine("No negative numbers");
                            isParsable = false;
                        }

                        if (length == 0)
                        {
                            Console.WriteLine("You entered 0 or nothing.. try again");
                            isParsable = false;
                        }

                    }

                }
                while (isParsable == false);

                do
                {
                    Console.WriteLine("Enter the width of our rectangle");

                    isParsable = decimal.TryParse(Console.ReadLine(), out decimal width);
                    if (isParsable == false)
                    {
                        Console.WriteLine("Could not parse. try again");
                    }

                    if (isParsable)
                    {
                        if (width < 0)
                        {
                            Console.WriteLine("No negative numbers");
                            isParsable = false;
                        }

                        if (width == 0)
                        {
                            Console.WriteLine("You entered 0 or nothing.. try again");
                            isParsable = false;
                        }

                        floorSize = length * width;
                    }

                }
                while (isParsable == false);

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
                double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
                floorSize = Convert.ToDecimal(area);
            }
            // circles
            if (floorType == 3)
            {
                Console.WriteLine("Would you like to calculate your circle by radius or diameter? enter r for radius, else it will be by diameter.");

                string circleChoice = Console.ReadLine();
                if (circleChoice == "r")
                {
                    do
                    {
                        Console.WriteLine("Enter your radius to calculate your floor size");
                        isParsable = decimal.TryParse(Console.ReadLine(), out decimal radius);

                        if (radius < 0)
                        {
                            Console.WriteLine("No negative numbers.");
                        }

                        if (radius == 0)
                        {
                            Console.WriteLine("You entered 0 or nothing.. try again");
                        }

                        if (isParsable)
                        {
                            radius *= radius;
                            floorSize = Convert.ToDecimal(Math.PI) * radius;
                            double floorSizedouble = Convert.ToDouble((floorSize));
                            floorSizedouble = Math.Sqrt(floorSizedouble);
                            floorSize = Convert.ToDecimal(floorSizedouble);
                        }

                    }
                    while (isParsable == false);

                }

                else
                {
                    do
                    {
                        Console.WriteLine("Enter your diameter to calculate your circle area by diameter");

                        isParsable = decimal.TryParse(Console.ReadLine(), out decimal diameter);

                        if (diameter < 0)
                        {
                            Console.WriteLine("No negative numbers.");
                        }

                        if (diameter == 0)
                        {
                            Console.WriteLine("You entered 0 or nothing.. try again");
                        }

                        if (isParsable)
                        {
                            floorSize = Convert.ToDecimal(Math.PI) * diameter;
                            double floorSizeDouble = Convert.ToDouble((floorSize));
                            floorSizeDouble = Math.Sqrt(floorSizeDouble);
                            floorSize = Convert.ToDecimal(floorSizeDouble);
                        }

                    }
                    while (isParsable == false);
                }

            }

            // the amount of work hours needed for your specified floor.
            decimal materialCost = floorSize * costPerTile;
            Console.WriteLine($"The Material cost is:{Math.Round(materialCost, 3)} Dollars");

            // hours needed to cover the specified floor with tiles
            decimal workHours = floorSize / FLOORINGPERHOUR;
            Console.WriteLine($"The amount of work hours needed for your floor: {Math.Round(workHours, 3)}");

            // your wagecost for flooring your specific floor
            decimal wageCost = workHours * COSTPERHOUR;
            Console.WriteLine($"The cost of the actual flooring: {Math.Round(wageCost, 3)} Dollars");

            // the complete cost of flooring and material
            decimal totalCost = wageCost + materialCost;
            Console.WriteLine($"Your total cost is:{Math.Round(totalCost, 3)} Dollars");

        }
    }
}