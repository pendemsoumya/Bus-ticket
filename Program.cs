using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Transport;

class Program
{
    static void Main()
    {


        Bus c1 = new Bus("AC", 9, "Hyderabad", "Mumbai", 23, 1);
            Console.WriteLine(c1.GeneratorBusId());
        Console.WriteLine(c1.GeneratingBusName());
            Console.WriteLine(c1.FindTicketPrice());
        
    }
}
