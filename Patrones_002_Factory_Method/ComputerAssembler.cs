using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_002_Factory_Method
{
    class ComputerAssembler
    {

        public void AssembleComputer(ComputerFactory factory)
        {

            Computer computer = factory.GetComputer();
            Console.WriteLine("assembled a {0} running at {1} MHz",
               computer.GetType().FullName, computer.Mhz);

        }//AssembleComputer

    }//ComputerAssembler
}
