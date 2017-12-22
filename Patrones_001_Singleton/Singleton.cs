using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_001_Singleton
{
    public class Singleton
    {
        //Al ser static, solo puede haber uno
        private static Singleton _singleton;
        private static int contador;

        //Constructoor privado
        private Singleton()
        {
            contador = 0;
        }

        //A través de esta función me aseguro su creación
        public static Singleton Instance
        {
            get
            {
                if (_singleton == null) _singleton = new Singleton();

                return _singleton;
            }
        }

        public string Saluda()
        {
            contador++;
            return "¡Hola! Soy Singleton :-) (" + contador.ToString() + ")";
        }
    }
}
