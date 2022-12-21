namespace CostOfTile
{
    public class Program
    {
        static void Main()
        {
            decimal width;
            decimal length;
            decimal costPerTile;
            bool widthIsParsable;
            bool lengthIsParsable;
            bool costPerTileIsParsable;
            decimal floorSize;
            decimal totalCost;
            Console.WriteLine("Welcome to the Tile Cost Processing software");
            Console.WriteLine("Here you will enter width and length of floor");
            Console.WriteLine("And also the cost per floor tile");
            Console.WriteLine("This software will then return the cost of the total");
            do
            {
                do
                {
                    Console.WriteLine("Input the Width of the floor");
                    widthIsParsable = decimal.TryParse(Console.ReadLine(), out width);
                    if (widthIsParsable == false)
                    {
                        Console.WriteLine("Your input wasnt a number. Try again.");
                    }
                } while (widthIsParsable == false);

                do
                {
                    Console.WriteLine("Insert the length of your floor");
                    lengthIsParsable = decimal.TryParse(Console.ReadLine(), out length);
                    if (lengthIsParsable == false)
                    {
                    }
                } while (lengthIsParsable == false);

                do
                {
                    Console.WriteLine("Insert the cost of your Tile");
                    costPerTileIsParsable = decimal.TryParse(Console.ReadLine(), out costPerTile);
                    if (costPerTileIsParsable == false)
                    {
                        Console.WriteLine("Your input wasnt a number. Try again.");
                    }
                } while (costPerTileIsParsable == false);

            }
            while (widthIsParsable == false || lengthIsParsable == false || costPerTileIsParsable == false);

            // Here we should calculate the cost of the flooring process 
            // something like
            // 
            floorSize = width * length;
            totalCost = floorSize * costPerTile;
            Console.WriteLine($"Your total cost is:{totalCost}");
        }
    }
}