using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_002_Factory_Method
{
    class ConcreteComputerFactory : ComputerFactory
    {

        public override Computer GetComputer()
        {

            return new ConcreteComputer();

        }//GetComputer

    }//ConcreteComputerFactory
}
