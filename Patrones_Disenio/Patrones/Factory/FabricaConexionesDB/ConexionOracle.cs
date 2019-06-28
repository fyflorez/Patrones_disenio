using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_Diseño.Patrones.Factory
{
    public class ConexionOracle:IConexion
    {
        public void Conectar()
        {
            Console.WriteLine("Conectar Oracle");
        }
        public void Desconectar() {
            Console.WriteLine("Desconectar Oracle");
        }
    }
}
