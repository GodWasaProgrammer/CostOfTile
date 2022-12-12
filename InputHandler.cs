using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CostOfTile
{
    public class InputHandler
    {
        int Width;
        int Length;
        int CostPerTile;
        
        static void FloorCalculations(int Width, int Length, int CostPerTile)
        {
            // Here we should calculate the cost of the flooring process 
            // something like
            // 
            int FloorSize = Width * Length;
            int TotalCost = FloorSize * CostPerTile;
            Console.WriteLine($"Your total cost is:{TotalCost}");
        }
         public void Input()
        {
            bool IsParsable; // Ensures that we successfully parsed
            do
            {
                Console.WriteLine("Input the Width of the floor");
                IsParsable = Int32.TryParse(Console.ReadLine(), out Width);
            }
            while (IsParsable == false);
            IsParsable= false;
            do
            { 
                Console.WriteLine("Insert the length of your floor");
                IsParsable = Int32.TryParse(Console.ReadLine(), out Length);
            }
            while (IsParsable == false);
            IsParsable= false;
            do
            {
                Console.WriteLine("Insert the cost of your Tile");
                IsParsable = Int32.TryParse (Console.ReadLine(), out CostPerTile);
            }
            while (IsParsable == false);
            IsParsable = false;
            FloorCalculations(Width, Length, CostPerTile);
        }
    }
}
