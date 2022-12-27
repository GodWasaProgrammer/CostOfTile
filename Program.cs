namespace CostOfTile
{
    public class Program
    {
        const decimal COSTPERHOUR = 86; // dollars
        const decimal FLOORINGPERHOUR = 18.580608M; // square centimeters ( 20 foot )
        static void Main()
        {
            decimal width;
            decimal length;
            decimal costPerTile;
            decimal floorSize;
            decimal materialCost;
            decimal totalCost;
            decimal workHours;
            decimal wageCost;
            bool isParsable;
            Console.WriteLine("Welcome to the Tile Cost Processing software");
            Console.WriteLine("Here you will enter width and length of floor");
            Console.WriteLine("And also the cost per floor tile");
            Console.WriteLine("This software will then return the cost of the total");

            do
            {
                Console.WriteLine("Input the Width of the floor");
                isParsable = decimal.TryParse(Console.ReadLine(), out width);
                if (isParsable == false)
                {
                    Console.WriteLine("Your input wasnt a number. Try again.");
                }

            } while (isParsable == false);

            do
            {
                Console.WriteLine("Insert the length of your floor");
                isParsable = decimal.TryParse(Console.ReadLine(), out length);
                if (isParsable == false)
                {
                    Console.WriteLine("Your input wasnt a number. Try again.");
                }

            } while (isParsable == false);

            do
            {
                Console.WriteLine("Insert the cost of your Tile");
                isParsable = decimal.TryParse(Console.ReadLine(), out costPerTile);
                if (isParsable == false)
                {
                    Console.WriteLine("Your input wasnt a number. Try again.");
                }

            } while (isParsable == false);

            Console.WriteLine("Is your floor a Rectangle? if yes, type y");
            string floorType = Console.ReadLine();

            // Here we should calculate the cost of the flooring process on a rectangular room
            // something like
            // 
            floorSize = width * length;
            
            // rectangle
            if (floorType == "y")
            {
                
            }
            // and if its not a rectangle its a god damn triangle right? lets F'n hope so.
            else
            {
                floorSize = width * length / 2;
                
            }
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