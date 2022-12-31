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


            // triangle, 2 different methods of calculation, herons formula and pythagoras ( b * h )
            if (floorType == 2)
            {
                int selector;
                do
                {
                    Console.WriteLine("would you like to calculate by base & height? enter 1,\n otherwise it will be calculated by giving us the length of the three sides");

                    isParsable = Int32.TryParse(Console.ReadLine(), out selector);

                    if (isParsable == false)
                    {
                        Console.WriteLine("Could not parse. try again");
                    }

                }
                while (isParsable == false);

                if (selector == 1)
                {
                    decimal baseOfTriangle;
                    do
                    {
                        Console.WriteLine("enter the base of your triangle");
                        isParsable = decimal.TryParse(Console.ReadLine(), out baseOfTriangle);

                        if (isParsable == false)
                        {
                            Console.WriteLine("Could not parse. try again");
                        }

                        if (isParsable)
                        {
                            if (baseOfTriangle < 0)
                            {
                                Console.WriteLine("No negative numbers");
                                isParsable = false;
                            }

                            if (baseOfTriangle == 0)
                            {
                                Console.WriteLine("You entered 0 or nothing.. try again");
                                isParsable = false;
                            }

                        }

                    }
                    while (isParsable == false);

                    do
                    {
                        Console.WriteLine("Enter the height of your triangle");
                        isParsable = decimal.TryParse(Console.ReadLine(), out decimal height);

                        if (isParsable == false)
                        {
                            Console.WriteLine("Could not parse. try again");
                        }

                        if (isParsable)
                        {
                            if (height < 0)
                            {
                                Console.WriteLine("No Negative numbers");
                                isParsable = false;
                            }

                            if (height == 0)
                            {
                                Console.WriteLine("You entered 0 or nothing.. try again");
                                isParsable = false;
                            }

                            floorSize = baseOfTriangle * height / 2;

                        }

                    }
                    while (isParsable == false);

                }

                else
                {
                    double sideA;
                    decimal sideB;
                    Console.WriteLine("Enter your 3 sides of your triangle");
                    do
                    {
                        Console.WriteLine($"Enter side A");
                        isParsable = decimal.TryParse(Console.ReadLine(), out sideA);

                        if (isParsable == false)
                        {
                            Console.WriteLine("Couldnt parse. try again");
                        }

                        if (isParsable)
                        {
                            if (sideA < 0)
                            {
                                Console.WriteLine("No negative numbers");
                                isParsable = false;
                            }

                            if (sideA == 0)
                            {
                                Console.WriteLine("You entered 0 or nothing.. try again");
                            }

                        }

                    }
                    while (isParsable == false);

                    do
                    {
                        Console.WriteLine($"Enter side B");
                        isParsable = decimal.TryParse(Console.ReadLine(), out sideB);

                        if (isParsable == false)
                        {
                            Console.WriteLine("Couldnt parse. try again");
                        }

                        if (isParsable)
                        {
                            if (sideB < 0)
                            {
                                Console.WriteLine("No negative numbers");
                                isParsable = false;
                            }

                            if (sideB == 0)
                            {
                                Console.WriteLine("You entered 0 or nothing.. try again");
                            }

                        }

                    }
                    while (isParsable == false);

                    do
                    {
                        Console.WriteLine($"Enter side C");
                        isParsable = decimal.TryParse(Console.ReadLine(), out decimal sideC);

                        if (isParsable == false)
                        {
                            Console.WriteLine("Couldnt parse. try again");
                        }

                        if (isParsable)
                        {
                            if (sideC < 0)
                            {
                                Console.WriteLine("No negative numbers");
                                isParsable = false;
                            }

                            if (sideC == 0)
                            {
                                Console.WriteLine("You entered 0 or nothing.. try again");
                            }

                            double a = Convert.ToDouble(sideA);
                            double b = Convert.ToDouble(sideB);
                            double c = Convert.ToDouble(sideC);
                            double s = (a + b + c);
                            double Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                            floorSize = Convert.ToDecimal(Area);
                        }

                    }
                    while (isParsable == false);

                }

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
            decimal materialCost;
            materialCost = floorSize * costPerTile;
            Console.WriteLine($"The Material cost is:{Math.Round(materialCost, 3)} Dollars");

            // hours needed to cover the specified floor with tiles
            decimal workHours;
            workHours = floorSize / FLOORINGPERHOUR;
            Console.WriteLine($"The amount of work hours needed for your floor: {Math.Round(workHours, 3)}");

            // your wagecost for flooring your specific floor
            decimal wageCost;
            wageCost = workHours * COSTPERHOUR;
            Console.WriteLine($"The cost of the actual flooring: {Math.Round(wageCost, 3)} Dollars");

            // the complete cost of flooring and material
            decimal totalCost;
            totalCost = wageCost + materialCost;
            Console.WriteLine($"Your total cost is:{Math.Round(totalCost, 3)} Dollars");

        }
    }
}