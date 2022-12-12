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
        int AreaToCover;
        void FloorCalculations(int Width, int Length, int CostPerTile)
        {
            // Here we should calculate the cost of the flooring process 
            // something like
            // 
            int FloorSize = Width * Length;
            int TotalCost = FloorSize * CostPerTile;
            int result = TotalCost * AreaToCover;
            Console.WriteLine($"Your total cost is:{result}");
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
            do
            {
                Console.WriteLine("Insert the room area you wish to cover");
                IsParsable = Int32.TryParse(Console.ReadLine(), out AreaToCover);
            }
            while (IsParsable == false);
            IsParsable = false;
            FloorCalculations(Width, Length, CostPerTile);
        }
    }
}
