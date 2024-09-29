using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje4
{
    internal class Perro : Animal
    {
        public override void caminar()
        {
            Console.WriteLine("El perro camina");
        }

        public override void comer()
        {
            Console.WriteLine("El perro come");
        }

        public override void dormir()
        {
            Console.WriteLine("El perro duerme");
        }

        public override void hacerRuido()
        {
            Console.WriteLine("El perro hace ruido");
        }
    }
}
