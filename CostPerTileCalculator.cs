using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CostOfTile
{
    public class CostPerTileCalculator
    {
        int width;
        int length;
        int costPerTile;
        bool widthIsParsable;
        bool lengthIsParsable;
        bool costPerTileIsParsable;
        int floorSize;
        int totalCost;
        void FloorCalculations(int width, int length, int costPerTile)
        {
            // Here we should calculate the cost of the flooring process 
            // something like
            // 
            floorSize = width * length;
            totalCost = floorSize * costPerTile;
            Console.WriteLine($"Your total cost is:{totalCost}");
        }

        public void Input()
        {
            do
            {
                if (widthIsParsable == false)
                {
                    Console.WriteLine("Input the Width of the floor");
                    widthIsParsable = Int32.TryParse(Console.ReadLine(), out width);
                    
                }

                if (lengthIsParsable == false)
                {
                    Console.WriteLine("Insert the length of your floor");
                    lengthIsParsable = Int32.TryParse(Console.ReadLine(), out length);
                }

                if (costPerTileIsParsable == false)
                {
                    Console.WriteLine("Insert the cost of your Tile");
                    costPerTileIsParsable = Int32.TryParse(Console.ReadLine(), out costPerTile);
                }

            }
            while (widthIsParsable == false || lengthIsParsable == false || costPerTileIsParsable == false);

            FloorCalculations(width, length, costPerTile);
        }
    }
}
