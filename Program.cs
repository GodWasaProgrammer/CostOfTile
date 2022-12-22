namespace CostOfTile
{
    public class Program
    {
        static void Main()
        {
            decimal width;
            decimal length;
            decimal costPerTile;
            decimal floorSize;
            decimal totalCost = 0;
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

            isParsable = false;
            do
            {
                Console.WriteLine("Insert the length of your floor");
                isParsable = decimal.TryParse(Console.ReadLine(), out length);
                if (isParsable == false)
                {
                    Console.WriteLine("Your input wasnt a number. Try again.");
                }

            } while (isParsable == false);

            isParsable = false;
            do
            {
                Console.WriteLine("Insert the cost of your Tile");
                isParsable = decimal.TryParse(Console.ReadLine(), out costPerTile);
                if (isParsable == false)
                {
                    Console.WriteLine("Your input wasnt a number. Try again.");
                }

            } while (isParsable == false);


            Console.WriteLine("Is your floor a Rectangle? if yes, type y, otherwise, type n");
            string ?floorType = Console.ReadLine();

            // Here we should calculate the cost of the flooring process on a rectangular room
            // something like
            // 
            if (floorType == "y")
            {
                floorSize = width * length;
                totalCost = floorSize * costPerTile;
                
            }
            
            // and if its not a rectangle its a god damn triangle right? lets F'n hope so.
            if (floorType == "n")
            {
                floorSize = width * length / 2;
                totalCost = floorSize * costPerTile;
            }

            Console.WriteLine($"Your total cost is:{totalCost}");

            

        }
    }
}