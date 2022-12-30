using System.Diagnostics.Metrics;

namespace CostOfTile
{
    public class Program
    {
        const decimal COSTPERHOUR = 86; // dollars
        const decimal FLOORINGPERHOUR = 18.580608M; // square centimeters ( 20 foot )
        const decimal MYPI = 3.14159265358979M;
        static void Main()
        {
            decimal costPerTile;
            bool isParsable;
            Console.WriteLine("Welcome to the Tile Cost Processing software");
            Console.WriteLine("Here you will enter width and length of floor");
            Console.WriteLine("And also the cost per floor tile");
            Console.WriteLine("This software will then return the cost of the total");

            do
            {
                Console.WriteLine("Insert the cost of your Tile");
                isParsable = decimal.TryParse(Console.ReadLine(), out costPerTile);

                if (isParsable == false)
                {
                    Console.WriteLine("Your input wasnt a number. Try again.");
                }

            } while (isParsable == false);

            Console.WriteLine("Pick your floortype, enter the correlating number");
            Console.WriteLine("1. rectangle");
            Console.WriteLine("2. triangle");
            Console.WriteLine("3. Circle");
            int floorType;
            do
            {
                isParsable = Int32.TryParse(Console.ReadLine(), out floorType);

                if (floorType != 1 && floorType != 2 && floorType != 3)
                {
                    Console.WriteLine("That is not a valid option.");
                }

            }
            while ((isParsable == false) && (floorType != 1) && (floorType != 2) && (floorType != 3));

            decimal baseOfTriangle = 0;
            decimal height = 0;
            decimal width = 0;
            decimal length = 0;
            decimal radius = 0;
            decimal diameter = 0M;
            decimal floorSize = 0;
            string printParameterName = "meme";
            string choice = "";

            // controls our iterationcounter logic -_-
            int iterationcounter = 0;

            if ((floorType == 1) || (floorType == 2))
            {
                iterationcounter = 2;
            }

            if (floorType == 3)
            {
                iterationcounter = 1;
            }

            // our massive loop of hell
            do
            {
                // rectangle
                if (floorType == 1)
                {
                    // if our counter is on 2, its time for width
                    if (iterationcounter == 2)
                    {
                        printParameterName = "width";

                    }
                    // otherwise its time for length
                    if (iterationcounter == 1)
                    {
                        printParameterName = "length";
                    }

                }

                // triangle
                if (floorType == 2)
                {
                    // if our counter is on 2
                    if (iterationcounter == 2)
                    {
                        printParameterName = "base";
                    }
                    // if our counter is on 1
                    if (iterationcounter == 1)
                    {
                        printParameterName = "height";
                    }

                }
                // circle
                if (floorType == 3)
                {
                    Console.WriteLine("Would you like to calculate your floorsize based on radius or diameter? type r if you want do it by radius");

                    choice = Console.ReadLine();
                    choice = choice.ToLower();

                    // did you input r? if so, this
                    if (choice == "r")
                    {
                        printParameterName = "radius";

                    }
                    // otherwise its diameter
                    else
                    {
                        printParameterName = "diameter";

                    }

                }
                // prints whatever we calculating at the moment
                Console.WriteLine($"Input the {printParameterName} of the floor");

                // parses and puts out our value, parametervalue is passed on later on in the if statements
                isParsable = decimal.TryParse(Console.ReadLine(), out decimal parameterValue);
                // couldnt parse your BS
                if (isParsable == false)
                {
                    Console.WriteLine("Your input wasnt a number. Try again.");
                }
                // if its a rectangle...
                if (floorType == 1)
                {    // and our iterationcounter is 2
                    if (iterationcounter == 2)
                    {
                        width = parameterValue;
                    }

                    // if our counter is at 1
                    if (iterationcounter == 1)
                    {
                        length = parameterValue;
                    }

                }
                // if its a triangle
                if (floorType == 2)
                {   // if counter is at 2
                    if (iterationcounter == 2)
                    {
                        baseOfTriangle = parameterValue;
                    }

                    // if counter is at 1
                    if (iterationcounter == 1)
                    {
                        height = parameterValue;
                    }

                }
                // if its a circle
                if (floorType == 3)
                {   // if we wanted to calculate it by radius
                    if (choice == "r")
                    {
                        radius = parameterValue;
                    }

                    // otherwise we will do it by diameter
                    else
                    {
                        diameter = parameterValue;
                    }

                }
                // if we successfully parsed
                if (isParsable)
                {
                    iterationcounter--;
                }

            }
            while (isParsable == false || iterationcounter > 0);

            if (floorType == 1)
            {
                floorSize = width * length;
            }

            if (floorType == 2)
            {
                floorSize = baseOfTriangle * height / 2;
            }

            // Area = π·r 2
            if (floorType == 3)
            {
                if (choice == "r")
                {
                    floorSize = MYPI * (radius * radius);
                }

                else
                {
                    floorSize = MYPI * diameter;
                }

            }

            decimal materialCost;
            decimal totalCost;
            decimal workHours;
            decimal wageCost;

            // the amount of work hours needed for your specified floor.
            materialCost = floorSize * costPerTile;

            Console.WriteLine($"The Material cost is:{Math.Round(materialCost, 3)} Dollars");

            // hours needed to cover the specified floor with tiles
            workHours = floorSize / FLOORINGPERHOUR;
            Console.WriteLine($"The amount of work hours needed for your floor: {Math.Round(workHours, 3)}");

            // your wagecost for flooring your specific floor
            wageCost = workHours * COSTPERHOUR;

            Console.WriteLine($"The cost of the actual flooring: {Math.Round(wageCost, 3)} Dollars");

            // the complete cost of flooring and material
            totalCost = wageCost + materialCost;
            Console.WriteLine($"Your total cost is:{Math.Round(totalCost, 3)} Dollars");

        }

    }

}