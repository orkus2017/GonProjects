using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_002_Factory_Method
{
    class BrandXFactory : ComputerFactory
    {

        public override Computer GetComputer()
        {

            return new BrandXComputer();

        }//GetComputer

    }//BrandXFactory
}
