using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables//
            string PotentialDifference;
            double InputCurrentFlowingOfTheWire;
            double InputResistanceOfTheWire;
            double Total;

            //Codes//
            Console.WriteLine("\"Welcome to Program4\"");
            Console.WriteLine();
            Console.WriteLine("Input Current Flowing Through The Wire");
            Console.WriteLine();
            PotentialDifference = Console.ReadLine();
            InputCurrentFlowingOfTheWire = Convert.ToDouble(PotentialDifference);
            Console.WriteLine();
            Console.WriteLine("Input The Resistance Of The Wire");
            Console.WriteLine();
            PotentialDifference = Console.ReadLine();
            InputResistanceOfTheWire = Convert.ToDouble(PotentialDifference);
            Console.WriteLine();
            Total = InputCurrentFlowingOfTheWire * InputResistanceOfTheWire;
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("The Potential Difference of the wire \nwith the Current Flowing of {0} and the  \nResistance of {1} is {2}", InputCurrentFlowingOfTheWire, InputResistanceOfTheWire, Total);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
